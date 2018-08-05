using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {

	public float theDistance;
	public GameObject ActionText;
	public GameObject ActionQuest;
	public GameObject UIQuest;
	public GameObject thePlayer;
	public GameObject theCamera;
	
	// Update is called once per frame


	void Update () {
		theDistance = RayCasting.distanceFrom;
		if (Input.GetMouseButtonDown(0)) {
			UIQuest.SetActive (false);
			theCamera.SetActive (false);
			thePlayer.SetActive (true);
		}
	}
	void OnMouseOver(){
		
		if(theDistance <= 6){
			ActionText.SetActive(true);
			ActionQuest.SetActive(true);
		}

		if(Input.GetButtonDown("Action")){
			if(theDistance <=6){
				ActionText.SetActive(false);
				ActionQuest.SetActive(false);
				UIQuest.SetActive(true);
				theCamera.SetActive(true);
				thePlayer.SetActive(false);

		}

	}
	
	}

	void OnMouseExit(){
		ActionText.SetActive (false);
		ActionQuest.SetActive (false);
	}
}
