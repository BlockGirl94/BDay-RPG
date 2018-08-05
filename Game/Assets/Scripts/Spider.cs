using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour {

	public int enemyHealth = 10;
	public float distanceFrom;
	public GameObject theSpider;
	public int spiderStatus;

	void DeductPoints (int damageAmount) {
		enemyHealth -= damageAmount;
	}

	void Update () {
		distanceFrom = RayCasting.distanceFrom;
		if (enemyHealth <= 0) {
			if (spiderStatus<9 && spiderStatus >0) {
				StartCoroutine (Attack());
			}

			if (spiderStatus == 0) {
				StartCoroutine (DeathSpider ());
			}
		}
	}

	IEnumerator DeathSpider () {
		spiderStatus = 9;
		yield return new WaitForSeconds (0.5f);
		theSpider.GetComponent<Animation> ().Play ("die");
	}
	IEnumerator Attack () {
		spiderStatus = 6;
		yield return new WaitForSeconds (0.5f);
		theSpider.GetComponent<Animation> ().Play ("attack");
	}
}

