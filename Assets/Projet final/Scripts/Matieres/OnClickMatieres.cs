using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClickMatieres : MonoBehaviour {
    
    AudioSource audioSource;
    [SerializeField]
    private Button activerAudioBouton;
    [SerializeField]
    private Button desactiverAudioBouton;

    [SerializeField]
    private Button zoomBouton;
    [SerializeField]
    private Button dezoomBouton;
    private bool zoomActif = false;


    [SerializeField]
    private GameObject canvasMatiere;


    // Dans le canvas où on choisit le nombre de questions
    [SerializeField]
    private Button commencerBouton;
    [SerializeField]
    private Button retourBouton;
    [SerializeField]
    private Button quaranteBouton;
    [SerializeField]
    private Button soixanteDixBouton;
    [SerializeField]
    private Button centBouton;
    [SerializeField]
    private Text quarantePourcentQuestionsText;
    [SerializeField]
    private Text soixanteDixPourcentQuestionsText;
    [SerializeField]
    private Text centPourcentQuestionsText;

    public static List<Questions> questionnaireChoisi { get; set; }
    public static int nombreQuestionsChoisi { get; set; }
    public static bool boolAudioActif { get; set; }

    private int quarantePourcent;
    private int soixanteDixPourcent;
    private int centPourcent;

    private Color blanc = new Color(1, 1, 1);
    private Color jaune = new Color(1, 0.84f, 0);

    
    // Use this for initialization
    void Start ()
    {
        
        if (PlayerPrefs.HasKey("boolAudioActif"))
            boolAudioActif = (PlayerPrefs.GetInt("boolAudioActif") == 1) ? true : false;
        else
            boolAudioActif = true;


        desactiverAudioBouton.gameObject.SetActive(true);
        activerAudioBouton.gameObject.SetActive(false);

        audioSource = GetComponent<AudioSource>();
        //audioSource.Play();
        activerDesactiverAudio(true);

        zoomBouton.gameObject.SetActive(true);
        dezoomBouton.gameObject.SetActive(false);

    }

    

	public void OnClickMerise()
	{
		SceneManager.LoadScene ("Merise");
	}

    //public static Matiere matiere { get; set; }

    public void onClickZoom()
    {
        zoomActif = !zoomActif;
        if(zoomActif)
        {
            zoomBouton.gameObject.SetActive(false);
            dezoomBouton.gameObject.SetActive(true);
        }
        else
        {
            zoomBouton.gameObject.SetActive(true);
            dezoomBouton.gameObject.SetActive(false);
        }
    }

    // Chargement du questionnaire
    public void onClickMatiere(string matiere)
    {
        switch (matiere)
        {
            case "anglais":
                Matiere anglais = new Anglais();
                anglais.chargementQuestions();
                questionnaireChoisi = anglais.getQuestionnaire();
                break;

            case "algebre":
                Matiere algebre = new Algebre();
                algebre.chargementQuestions();
                questionnaireChoisi = algebre.getQuestionnaire();
                break;

            /*case "analyse":
                Matiere anglais = new Anglais();
                anglais.chargementQuestions();
                questionnaireChoisi = anglais.getQuestionnaire();
                break;

            case "architecture":
                Matiere anglais = new Anglais();
                anglais.chargementQuestions();
                questionnaireChoisi = anglais.getQuestionnaire();
                break;*/

            case "baseDeDonnees":
                Matiere baseDeDonnees = new BaseDeDonnees();
                baseDeDonnees.chargementQuestions();
                questionnaireChoisi = baseDeDonnees.getQuestionnaire();
                break;

            /*case "bureautique":
                Matiere anglais = new Anglais();
                anglais.chargementQuestions();
                questionnaireChoisi = anglais.getQuestionnaire();
                break;*/

            case "droitCommercial":
                Matiere droitCommercial = new DroitCommercial();
                droitCommercial.chargementQuestions();
                questionnaireChoisi = droitCommercial.getQuestionnaire();
                break;//TODO droit commercial ~terminé

            case "droitSocietes":
                Matiere droitDesSocietes = new DroitDesSocietes();
                droitDesSocietes.chargementQuestions();
                questionnaireChoisi = droitDesSocietes.getQuestionnaire();
                break;

            case "fonctionnementEntreprises":
                Matiere introFonctionnementEntreprises = new IntroFonctionnementEntreprises();
                introFonctionnementEntreprises.chargementQuestions();
                questionnaireChoisi = introFonctionnementEntreprises.getQuestionnaire();
                break;

            case "web":
                Matiere web = new LangageDuWeb();
                web.chargementQuestions();
                questionnaireChoisi = web.getQuestionnaire();
                break;

            case "problemesEco":
                Matiere problemesEconomiquesContemporains = new ProblemesEconomiquesContemporains();
                problemesEconomiquesContemporains.chargementQuestions();
                questionnaireChoisi = problemesEconomiquesContemporains.getQuestionnaire();
                break;

            case "programmation":
                Matiere programmation = new Programmation();
                programmation.chargementQuestions();
                questionnaireChoisi = programmation.getQuestionnaire();
                break;

            case "programmationAvancee":
                Matiere programmationAvancee = new ProgrammationAvancee();
                programmationAvancee.chargementQuestions();
                questionnaireChoisi = programmationAvancee.getQuestionnaire();
                break;

            /*case "probabilites":
                Matiere anglais = new Anglais();
                anglais.chargementQuestions();
                questionnaireChoisi = anglais.getQuestionnaire();
                break;*/

            case "merise":
                Matiere merise = new Merise();
                merise.chargementQuestions();
                questionnaireChoisi = merise.getQuestionnaire();
                break;
        }

        centPourcent = questionnaireChoisi.Count;
        quarantePourcent = Mathf.RoundToInt(centPourcent * 0.4f);
        soixanteDixPourcent = Mathf.RoundToInt(centPourcent * 0.7f);

        // Affichage du nombre de questions dans les cases
        quarantePourcentQuestionsText.text = quarantePourcent.ToString();
        soixanteDixPourcentQuestionsText.text = soixanteDixPourcent.ToString();
        centPourcentQuestionsText.text = centPourcent.ToString();


        canvasMatiere.SetActive(false);

    }

    public void onClickRetourNombreQuestions()
    {
        canvasMatiere.SetActive(true);
    }

    //Choix du nombre de questions
    public void choixNombreQuestions(string nombre)
    {
        switch(nombre)
        {
            case "40":
                quaranteBouton.image.color = jaune;
                soixanteDixBouton.image.color = blanc;
                centBouton.image.color = blanc;
                nombreQuestionsChoisi = quarantePourcent;
                break;

            case "70":
                quaranteBouton.image.color = blanc;
                soixanteDixBouton.image.color = jaune;
                centBouton.image.color = blanc;
                nombreQuestionsChoisi = soixanteDixPourcent;
                break;

            default:
                quaranteBouton.image.color = blanc;
                soixanteDixBouton.image.color = blanc;
                centBouton.image.color = jaune;
                nombreQuestionsChoisi = centPourcent;
                break;
        }
    }

    public void commencerQuizz()
    {
        SceneManager.LoadScene("SceneDeQuizz");
    }

    public void activerDesactiverAudio(bool appelDansMethodeStart = false)
    {
        if(!appelDansMethodeStart)
            boolAudioActif = !boolAudioActif;

        int intAudioActif = 0;

        if (boolAudioActif)
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
}
