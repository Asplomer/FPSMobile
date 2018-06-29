using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerShoot : MonoBehaviour {


	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	// Use this for initialization
	void Update () {
		/*
		if (!isLocalPlayer) {
			return;
		}*/
		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * 3.0f;
		transform.Rotate (0, x, 0);
		transform.Rotate (0, 0, z);
		if (Input.GetKey ("Fire1")) {
			Fire ();
		}
	
	}

	
	// Update is called once per frame
	void Fire () {
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 6;
			Destroy (bullet, 2.0f);
		
		}











}