using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour {

	public static float distanceFrom;
	public float toTarget;
	// Update is called once per frame
	void Update () {
		RaycastHit hit;

		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)) {
			//Casts ray at point, direction and stores output
			toTarget = hit.distance;
			distanceFrom = toTarget;
		}
		
	}
}
