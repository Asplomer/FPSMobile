using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCube : MonoBehaviour 
{
	public float Speed = 1.0f;

	// Use this for initialization
	void Start ()
	{
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 pos = this.transform.position;

		if (Input.GetKey (KeyCode.RightArrow)) {
			pos.x += Speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			pos.x -= Speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			pos.y += Speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			pos.y -= Speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.W)) {
			pos.z += Speed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S)) {
			pos.z -= Speed * Time.deltaTime;
		}


		this.transform.position = pos;
	}
}
