using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Questions
{

	private string question;
	private List<Proposition> propositions = new List<Proposition>();
	private int nbPropositions = 0;


	public Questions(string question, Proposition proposition1, Proposition proposition2, Proposition proposition3= null, Proposition proposition4 = null)
	{
		this.question = question;	
		propositions.Add (proposition1);
		propositions.Add (proposition2);

		if(proposition3 != null)
			propositions.Add (proposition3);

		if(proposition4 != null)
			propositions.Add (proposition4);

		nbPropositions = propositions.Count;
	}

	public string getQuestion()
	{
		return question;
	}

	public List<Proposition> getPropositions()
	{
		// Faire en sorte de retourner une liste mélangée
		List<Proposition> propositionsMelangees = new List<Proposition>();
		int rnd = 0;
		for (int i = nbPropositions; i > 0; i--) 
		{
			rnd = Random.Range (0, i);
			propositionsMelangees.Add (propositions[rnd]);
			propositions.RemoveAt (rnd);
		}

		return propositionsMelangees;
	}
}
