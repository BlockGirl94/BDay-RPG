using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour {

	public float targetDistance;
	public float distanceAllowed = 3;
	public int damage = 3;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			RaycastHit hit;
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)) {
				targetDistance = hit.distance;
				if (targetDistance <= distanceAllowed) {
					hit.transform.SendMessage ("DeductPoints", damage, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
		
	}
}
 