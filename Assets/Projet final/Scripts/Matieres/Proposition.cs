using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proposition
{
	private string proposition;
	private bool estCorrecte;

	public Proposition(string proposition, bool estCorrecte)
	{
		this.proposition = proposition;
		this.estCorrecte = estCorrecte;		
	}

	public string getProposition()
	{
		return proposition;
	}

	public bool getEstCorrect()
	{
		return estCorrecte;
	}
}
