using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {
	public float boltSpeed;
	private float duration;
	public float lifetimeBullet;
	public GameObject onHit;
	void Start(){
		duration = 0.0f;

	}
	void OnTriggerEnter(Collider collider){


		if ((collider.tag == "Floor" || collider.tag == "Player")) {
			Instantiate (onHit, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
	void Update () {
		if(this.tag =="EBullet"){
			transform.Translate(Vector3.down* boltSpeed);
								
		}

		duration = duration + Time.deltaTime;
		if (duration >= lifetimeBullet) {

			Destroy (gameObject);
		}





	}



}
