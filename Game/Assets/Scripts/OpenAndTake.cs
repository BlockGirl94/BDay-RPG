using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndTake : MonoBehaviour {

	public GameObject fakeSword;
	public GameObject realSword;
	public GameObject chest;
	public float theDistance;



	// Update is called once per frame
	void Update () {
		theDistance = RayCasting.distanceFrom;

	}

	void OnMouseDown(){
		if (theDistance <= 5) {
			chest.GetComponent<Animation> ().Play ("ChestOpen");
			fakeSword.SetActive (true);
		}

			if (theDistance <= 1) {
				fakeSword.SetActive (false);
				realSword.SetActive (true);
			}
		}
}

