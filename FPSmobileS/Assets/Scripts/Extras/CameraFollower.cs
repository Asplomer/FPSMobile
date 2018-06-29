using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour 
{

	public Transform Target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 posPlayer= Target.position;
		transform.position = posPlayer;

		posPlayer.Normalize ();

		transform.rotation = Quaternion.LookRotation (Target.forward);


	}
}
