using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoniterPenis : MonoBehaviour {

	public static int DickValue = 0;
	public Text dickScore;
	public GameObject dick1;

	// Update is called once per frame
	void Update () {
		dickScore.text = "Dicks:" + DickValue;
		if (DickValue == 29) {
			dick1.SetActive (true);
		}
	}
		
}
