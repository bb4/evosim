using UnityEngine;
using System.Collections;


/*
 *		Author: 	Craig Lomax
 *		Date: 		06.09.2011
 *		URL:		clomax.me.uk
 *		email:		craig@clomax.me.uk
 *
 */


public class Catch : MonoBehaviour {
	
	Ether eth;
	Creature crt;
	
	void OnTriggerEnter (Collider col) {
		eth = GameObject.Find("Ether").GetComponent<Ether>();
		if (col.transform.tag == "Creature") {
			crt = col.GetComponent<Creature>();
			eth.addToEnergy(crt.kill());
		}
	}



}
