using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitBehaviour : MonoBehaviour {
	private float duration;
	public float lifetime;
	// Use this for initialization
	void Start () {
		duration = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		duration = duration + Time.deltaTime;
		if (duration >= lifetime) {
			Destroy (gameObject);
		}
	}
}
