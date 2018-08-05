using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour {

	public GameObject sword;
	public int swordStatus;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && swordStatus == 0) {
			StartCoroutine (SwingSwordFunction ());
		}
		
	}
	IEnumerator SwingSwordFunction(){
		swordStatus = 1;
		sword.GetComponent<Animation> ().Play ("SwingSword");
		swordStatus = 2;
		yield return new WaitForSeconds (1.0f);
		swordStatus = 0;
	}
}
