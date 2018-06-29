using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMovement : MonoBehaviour {
	public float boltSpeed;
	private float duration;
	public float lifetimeBullet;
	public GameObject onHit;
	void Start(){
		duration = 0.0f;
	
	}
	void OnTriggerEnter(Collider collider){
		//Debug.Log (collider.tag);

		if (collider.tag == "Enemy") {
			collider.gameObject.GetComponent<FoeScriptA> ().EnemyHealth -=1;
			Instantiate (onHit, transform.position, transform.rotation);
			Destroy (this.gameObject);
		}
	}
	void Update () {
		if(this.tag =="Bullet")				//(11)<--planning ahead :)
		{
			transform.Translate(Vector3.forward* boltSpeed);

			//this.Rigidbody.velocity = transform.forward * BoltSpeed;						
		}

		duration = duration + Time.deltaTime;
		if (duration >= lifetimeBullet) {
			
			Destroy (gameObject);
		}
	
	



	}
	


}
