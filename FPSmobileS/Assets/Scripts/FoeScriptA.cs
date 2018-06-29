using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoeScriptA : MonoBehaviour {
	public int EnemyHealth;

	//i need a way to check for an impact with a spell or player


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (EnemyHealth <= 0) {
			gameObject.GetComponent<Spawner> ().foeCount--;
			Destroy (gameObject); 
		}	
		//Debug.Log(EnemyHealth);
	}
}
