using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageCanvas : MonoBehaviour {

	[SerializeField]
	private Canvas menuPrincipaleCanvas;
	[SerializeField]
	private Canvas matieresCanvas;
	[SerializeField]
	private Canvas quitterCanvas;
	[SerializeField]
	private Canvas creditsCanvas;

	// Use this for initialization
	void Start () 
	{
		matieresCanvas.enabled = false;
		quitterCanvas.enabled = false;
		creditsCanvas.enabled = false;
		
	}
	
	public void onClickJouer()
	{
		menuPrincipaleCanvas.enabled = false;
		matieresCanvas.enabled = true;
		quitterCanvas.enabled = false;
		creditsCanvas.enabled = false;
		
	}

	public void onClickCredits()
	{
		menuPrincipaleCanvas.enabled = false;
		matieresCanvas.enabled = false;
		quitterCanvas.enabled = false;
		creditsCanvas.enabled = true;

	}

	public void onClickCreditsRetour()
	{
		menuPrincipaleCanvas.enabled = true;
		matieresCanvas.enabled = false;
		quitterCanvas.enabled = false;
		creditsCanvas.enabled = false;

	}

	public void onClickQuitter()
	{
		menuPrincipaleCanvas.enabled = false;
		matieresCanvas.enabled = false;
		quitterCanvas.enabled = true;
		creditsCanvas.enabled = false;

	}

	public void onClickQuitterNon()
	{
		menuPrincipaleCanvas.enabled = true;
		matieresCanvas.enabled = false;
		quitterCanvas.enabled = false;
		creditsCanvas.enabled = false;

	}


	public void onClickMatieresRetour()
	{
		menuPrincipaleCanvas.enabled = true;
		matieresCanvas.enabled = false;
		quitterCanvas.enabled = false;
		creditsCanvas.enabled = false;

	}
    
}
