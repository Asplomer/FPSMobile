using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BombExplosion : MonoBehaviour {
	private float duration;
	public float lifetime;
	public GameObject player;
	private bool notHit;
	Vector3 vec ;
	Vector3 bomb ;
	// Use this for initialization
	void Start () {
		duration = 0.0f;
		notHit = true;

		vec= player.transform.position;
		 bomb = this.transform.position;
	}
	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player" || notHit) {
			
				//collider.gameObject.GetComponent<PlayerHealth> ().Health -= 1;
				notHit = false;
		

		}
	}
	// Update is called once per frame
	void Update () {
		duration = duration + Time.deltaTime;


		if (duration >= lifetime) {
			Destroy (gameObject);
		}
	}
}
