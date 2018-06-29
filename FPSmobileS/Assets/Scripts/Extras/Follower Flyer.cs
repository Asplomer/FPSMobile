using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerFlyer : MonoBehaviour {

	public float speed = 1.8f;
	public Transform Target;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 pos1 = this.transform.position;
		Vector3 pos2 = Target.position;

		Vector3 dir = pos2 - pos1;
		dir.y = 1.0f;
		dir.Normalize ();

		transform.rotation = Quaternion.LookRotation (dir);
		pos1 += speed * Time.deltaTime * transform.forward;
		transform.position = pos1;

	}
}
