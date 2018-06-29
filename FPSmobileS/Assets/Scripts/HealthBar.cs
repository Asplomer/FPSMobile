using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

	public  GameObject Bar1;
	public  GameObject Bar2;
	public  GameObject Bar3;
	public  GameObject Bar4;
	public  GameObject Bar5;

	public GameObject player;

	void Update () {
		if((player.gameObject.GetComponent<PlayerHealth>().Health) <= 8)
			Destroy (Bar1);
		if((player.gameObject.GetComponent<PlayerHealth>().Health) <= 6)
			Destroy (Bar2);
		if((player.gameObject.GetComponent<PlayerHealth>().Health) <= 4)
			Destroy (Bar3);
		if((player.gameObject.GetComponent<PlayerHealth>().Health) <= 2)
			Destroy (Bar4);
		if((player.gameObject.GetComponent<PlayerHealth>().Health) <= 0)
			Destroy (Bar5);
		

	}
}
