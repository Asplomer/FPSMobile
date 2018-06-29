using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCasting : MonoBehaviour {

	public GameObject bulletPrefab;
	public GameObject bulletPrefab2;
	public Transform tipWandF;
	public Transform tipWandR;
	public Transform tipWandL;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			SimpleSpell();
		}
		if (Input.GetButtonDown("Fire2")){
			SpreadSpell();
		}
	}

	void SimpleSpell(){
		Instantiate(bulletPrefab, tipWandF.position, tipWandF.rotation);
	}

	void SpreadSpell(){
		Instantiate(bulletPrefab2, tipWandF.position, tipWandF.rotation);
		Instantiate(bulletPrefab2, tipWandL.position, tipWandL.rotation);
		Instantiate(bulletPrefab2, tipWandR.position, tipWandR.rotation);

	}
	/*
	void SimpleSpell(){
		Instantiate(bulletPrefab, tipWandF.position, tipWandF.rotation);
	}


*/
}