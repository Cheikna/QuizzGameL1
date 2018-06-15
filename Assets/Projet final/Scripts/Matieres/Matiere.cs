using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Matiere
{
	private List<Questions> questionnaire; 

	public Matiere()
	{
		this.questionnaire = new List<Questions>();		
	}

	public List<Questions> getQuestionnaire()
	{       
		return questionnaire;
	}

	public void ajouterQuestion(Questions question)
	{
		questionnaire.Add (question);
	}

	public abstract void chargementQuestions ();
}
