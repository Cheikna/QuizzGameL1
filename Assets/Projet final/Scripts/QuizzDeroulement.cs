using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizzDeroulement : MonoBehaviour {
    
    AudioSource audioSource;
    [SerializeField]
    private Button activerAudioBouton;
    [SerializeField]
    private Button desactiverAudioBouton;


    [SerializeField]
	private GameObject jeuCanvas;
	[SerializeField]
	private GameObject pauseCanvas;
    [SerializeField]
    private GameObject resultatFinalCanvas;

    private bool pauseJeu = false;
	[SerializeField]
	private Image chronometreImage;
	[SerializeField]
	private Text chronometreText;
    [SerializeField]
    private Text dateText;
    [SerializeField]
	private Text bonnesReponsesText;
    [SerializeField]
    private Text mauvaisesReponsesText;
    [SerializeField]
    private Text nombreQuestionRestantesText;
    [SerializeField]
    private Text accordQuestionText;
    [SerializeField]
    private Text totalReponsesText;
    private int bonnesReponses;
    private int mauvaisesReponses;
	private int nbQuestionsRepondus;
	private float tempsParQuestion = 30f;
	private float tempsRestant;

	[SerializeField]
	private Text question;
	[SerializeField]
	private Button bouton1;
	[SerializeField]
	private Button bouton2;
	[SerializeField]
	private Button bouton3;
	[SerializeField]
	private Button bouton4;
	[SerializeField]
	private Button validerBouton;
	[SerializeField]
	private Button suivantBouton;

	private int nbBoutons = 4;
	private bool finQuestionEnCours = false;
    private bool reponsesDejaVerifiees = false;
    private bool voirResultatFinal = false;
    private bool clickValiderFinQuestionEnCours = false;
	private int indexQuestionActuelle = 0;
	private int nombreQuestionsRestantes;

	private Color vert = new Color(0f, 1f, 0f);
	private Color rouge = new Color(1f, 0f, 0f);
	private Color clickReponse = new Color(1f, 0.65f, 0f);
	private Color normalBouton = new Color(0f, 0f, 0f);
	private Color blanc = new Color(1,1,1);

	List<Button> boutons = new List<Button> ();                    // bouton1 vrai | bouton2 faux | bouton3 vrai |bouton4 faux
	List<bool> boutonsCorrectes = new List<bool> ();			   //      true			false			true		 false
	List<bool> etatBoutons = new List<bool>();

	//Merise merise = new Merise ();
	List<Questions> questionnaire;

    //Resultat Final Canvas
    [SerializeField]
    private Text complimentText;
    [SerializeField]
    private Text resultatFinalText;

    // Use this for initialization
    void Start () 
	{
        audioSource = GetComponent<AudioSource>();
        activerDesactiverAudio(true);

        string date = Utilitaire.EnglishDayToFrench(System.DateTime.Now.DayOfWeek.ToString()) + " " + System.DateTime.Now.Day + " " + 
                      Utilitaire.NumberToMonth(System.DateTime.Now.Month) + " " + System.DateTime.Now.Year;
        dateText.text = date;
		boutons.Add (bouton1);
		boutons.Add (bouton2);
		boutons.Add (bouton3);
		boutons.Add (bouton4);


        questionnaire = OnClickMatieres.questionnaireChoisi;
		nombreQuestionsRestantes = OnClickMatieres.nombreQuestionsChoisi;
        totalReponsesText.text = "0";
        bonnesReponsesText.text = "0";
        mauvaisesReponsesText.text = "0";

        nouvelleQuestion ();

	}


	void nouvelleQuestion()
	{
        setInteractiviteBoutons(true);
        reponsesDejaVerifiees = false;
		boutonsCorrectes.Clear ();
		etatBoutons.Clear ();
        
        indexQuestionActuelle = Random.Range(0, nombreQuestionsRestantes);
        jeuCanvas.SetActive (true);
		pauseCanvas.SetActive (false);
        resultatFinalCanvas.SetActive(false);
		suivantBouton.gameObject.SetActive(false);
		validerBouton.gameObject.SetActive(true);
		finQuestionEnCours = false;
		clickValiderFinQuestionEnCours = false;

		tempsRestant = tempsParQuestion;
		chronometreImage.color = vert;
		// mise a jour des couleurs
		foreach(Button bouton in boutons)
		{
			ColorBlock cb = bouton.colors;
			cb.normalColor = normalBouton;
			bouton.colors = cb;	
			bouton.image.color = normalBouton;
		}

		Questions q = questionnaire[indexQuestionActuelle];
		question.text = q.getQuestion ();
		List<Proposition> propositions = q.getPropositions ();

		int i = 0;
		foreach (Proposition p in propositions) 
		{
			boutonsCorrectes.Add (p.getEstCorrect ());
			Button bouton = boutons [i]; 
			bouton.gameObject.SetActive (true);
			bouton.GetComponentInChildren<Text>().text = p.getProposition ();
			etatBoutons.Add (false);
			i++;
		}

		//Le reste des boutons qui ne doivent pas être affiché. Donc leur etat est toujours false
		for (int j = i; j < nbBoutons; j++) 
		{
			boutonsCorrectes.Add (false);
			boutons [j].gameObject.SetActive (false);
			etatBoutons.Add (false);
		}
        questionnaire.RemoveAt(indexQuestionActuelle);
        //nombreQuestionsRestantes--;


	}

	void Update()
	{
        nombreQuestionRestantesText.text = nombreQuestionsRestantes.ToString();
        // Verifie si on doit encore répondre à des questions
        if (nombreQuestionsRestantes > 0)
        {
            if (tempsRestant >= 0 && !pauseJeu)
            {
                chronometreImage.fillAmount = (tempsRestant) / tempsParQuestion;
                chronometreText.text = (Mathf.Floor(tempsRestant)).ToString();
                tempsRestant -= Time.deltaTime;

                if (tempsRestant < 10)
                    chronometreImage.color = rouge;
            }
            else if (tempsRestant < 0 && !clickValiderFinQuestionEnCours && !reponsesDejaVerifiees)
            {
                reponsesDejaVerifiees = false;
                finQuestionEnCours = true;
                suivantBouton.gameObject.SetActive(true);
                validerBouton.gameObject.SetActive(false);
            }

            if (Input.GetKeyUp(KeyCode.Escape))
                pauseJeu = !pauseJeu;

            if (finQuestionEnCours && !reponsesDejaVerifiees)
            {
                verificationReponse();
                reponsesDejaVerifiees = true;
            }

            if (nombreQuestionsRestantes <= 1)
                accordQuestionText.text = "question";

        }

    }


	public void onClickBoutonProposition(string indexAChoisir)
	{		
		if (!finQuestionEnCours) 
		{
			int index = int.Parse (indexAChoisir);
			etatBoutons [index] = !etatBoutons [index];
			if (etatBoutons [index]) 
			{
				ColorBlock cb = boutons [index].colors;
				cb.normalColor = blanc;
				boutons [index].colors = cb;
				boutons [index].image.color = clickReponse;
			
			} 
			else 
			{
				ColorBlock cb = boutons [index].colors;
				cb.normalColor = normalBouton;
				boutons [index].colors = cb;
				boutons [index].image.color = normalBouton;
			}
		}

	}


	

	public void onClickValiderReponses()
	{
        finQuestionEnCours = true;
		clickValiderFinQuestionEnCours = true;
		suivantBouton.gameObject.SetActive(true);
		validerBouton.gameObject.SetActive(false);
		tempsRestant = 0;
        verificationReponse();

        reponsesDejaVerifiees = true;
        nombreQuestionsRestantes--;
    }

	public void onClickQuestionSuivante()
	{
        if (nombreQuestionsRestantes > 0)
        {
            suivantBouton.gameObject.SetActive(false);
            validerBouton.gameObject.SetActive(true);
            nouvelleQuestion();
        }
        else
        {
            finQuestionnaire();
            voirResultatFinal = true;
        }

    }

    public void onClickBoutonPauseReprendre()
    {
        pauseJeu = !pauseJeu;
        verificationPause();
    }

    public void verificationPause()
    {
        if (pauseJeu)
        {
            Time.timeScale = 0;
            pauseCanvas.SetActive(true);
            jeuCanvas.SetActive(false);
        }
        else
        {
            Time.timeScale = 1;
            pauseCanvas.SetActive(false);
            if(voirResultatFinal)
                jeuCanvas.SetActive(false);
            else
                jeuCanvas.SetActive(true);
        }
    }


    public void verificationReponse()
	{
        setInteractiviteBoutons(false);
		int i = 0;
        
		//On incrémente cette variable de 1 à chaque fois que l'utilisateur a bien fait
		// c'est-à-dire que si la réponse est fausse alors il ne doit pas cliquer mais si la réponse est vraie il doit cliquer.
		int correction = 0;

		while (i < nbBoutons) 
		{
			// Si la reponse est correcte alors le bouton devient vert
			if (boutonsCorrectes [i])
            {
				ColorBlock cb = boutons[i].colors;
				cb.normalColor = blanc;
				boutons[i].colors = cb;
				boutons[i].image.color = vert;	
			}
			//Sinon si le bouton est faux et qu'il a été cliqué alors il devient roude
			else if (!boutonsCorrectes [i] && etatBoutons [i]) {
				ColorBlock cb = boutons[i].colors;
				cb.normalColor = blanc;
				boutons[i].colors = cb;
				boutons[i].image.color = rouge;				
			} 

            // On regarde la correspondance entre les boutons càd on regarde si le bouton doit être cliqué ou non et on compare à ce
            //que le joueur a fait
			if (boutonsCorrectes [i] == etatBoutons [i])
				correction++;
			
			i++;
		}

        // Si les 4 boutons sont correctes (les boutons invisibles seront forcément correctes)
		if (correction >= 4)
			bonnesReponses++;

		nbQuestionsRepondus++;
        bonnesReponsesText.text = bonnesReponses.ToString();
        mauvaisesReponsesText.text = (nbQuestionsRepondus - bonnesReponses).ToString();
        totalReponsesText.text = nbQuestionsRepondus.ToString();
		finQuestionEnCours = false;
        


    }

    public void finQuestionnaire()
    {
        string compliment = "";
        if(bonnesReponses < nbQuestionsRepondus * 0.25)
        {
            compliment = "VOUS DEVEZ SOLIDIFIER VOS CONNAISSANCES";
        }
        else if(bonnesReponses < nbQuestionsRepondus * 0.5)
        {
            compliment = "PRESQUE";
        }
        else if (bonnesReponses < nbQuestionsRepondus * 0.75)
        {
            compliment = "BIEN";
        }
        else if (bonnesReponses < nbQuestionsRepondus)
        {
            compliment = "TRES BIEN";
        }
        else
        {
            compliment = "EXCELLENT TRAVAIL";
        }

        complimentText.text = compliment;
        resultatFinalText.text = bonnesReponses + " sur " + nbQuestionsRepondus;

        jeuCanvas.SetActive(false);
        resultatFinalCanvas.SetActive(true);
    }

	public void onClickRetourMenu()
	{
		SceneManager.LoadScene ("Menu");
	}

    public void activerDesactiverAudio(bool appelDansMethodeStart = false)
    {
        if(!appelDansMethodeStart)
            OnClickMatieres.boolAudioActif = !OnClickMatieres.boolAudioActif;

        int intAudioActif = 0;

        if (OnClickMatieres.boolAudioActif)
        {
            intAudioActif = 1;
            desactiverAudioBouton.gameObject.SetActive(true);
            activerAudioBouton.gameObject.SetActive(false);
            audioSource.Play();
        }
        else
        {
            desactiverAudioBouton.gameObject.SetActive(false);
            activerAudioBouton.gameObject.SetActive(true);
            audioSource.Pause();
        }

        PlayerPrefs.SetInt("boolAudioActif", intAudioActif);


    }

    private void setInteractiviteBoutons(bool interactif)
    {
        if(interactif)
        {
            foreach (Button bouton in boutons)
            {

                ColorBlock cb = bouton.colors;
                cb.colorMultiplier = 1f;
                bouton.colors = cb;
                bouton.interactable = true;
            }
        }
        else
        {
            foreach (Button bouton in boutons)
            {
                ColorBlock cb = bouton.colors;
                cb.colorMultiplier = 5f;
                bouton.colors = cb;
                bouton.interactable = false;

            }
        }
    }
}
