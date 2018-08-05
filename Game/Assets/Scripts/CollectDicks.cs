using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDicks: MonoBehaviour {

	public AudioSource audio;
	public GameObject dick; //important to define game object


	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 2, 0, Space.World); //rotate heart on y axis relative to world

	}
	// is trigger
	void OnTriggerEnter(){ 
		audio.Play ();  //play heart sound on collection
		MoniterPenis.DickValue += 1;
		dick.SetActive (false);
	}
}
