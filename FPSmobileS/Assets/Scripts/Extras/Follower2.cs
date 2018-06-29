using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower2 : MonoBehaviour {

	public float speed = 1.8f;
	public Transform Target;
	public float timerBomber =3.0f;
	public float timer;
	public GameObject bomb;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		if (timer != 0.0f) {
			timer = timer + Time.deltaTime;
		}
	//	Debug.Log (timer);
		Vector3 pos1 = this.transform.position;
		Vector3 pos2 = Target.position;

		Vector3 dir = pos2 - pos1;
		dir.y = 0.0f;
		dir.Normalize ();

		transform.rotation = Quaternion.LookRotation (dir);
		pos1 += speed * Time.deltaTime * transform.forward;
		transform.position = pos1;
		if (pos1.x + 3.0f > pos2.x && timer >= 0.0f) {
			Instantiate (bomb, transform.position, transform.rotation);
			timer -= timerBomber;

		}		
	}
}
