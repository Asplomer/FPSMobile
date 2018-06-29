using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShip : MonoBehaviour 
{
	public float Accel = 1.0f;
	public float RotSpeed = 5.0f;
	Vector3 speed = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = this.transform.position;

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.rotation *= Quaternion.AngleAxis (-RotSpeed * Time.deltaTime, Vector3.forward);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.rotation *= Quaternion.AngleAxis (RotSpeed * Time.deltaTime, Vector3.forward);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			speed += this.transform.up * Accel * Time.deltaTime;
		}

		pos += speed * Time.deltaTime;

		this.transform.position = pos;
	}
}
