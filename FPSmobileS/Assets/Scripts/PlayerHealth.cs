using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public int Health;
	private float iframes;
	private bool hit;
	//i need a way to check for an impact with a spell or player


	void Start () {
		iframes = 0f;
		hit = false;
	}
	void OnTriggerEnter(Collider collider){


		if ((collider.tag == "Enemy")&& !hit) {
			Health--;
			hit = true;
		}
		if ((collider.tag == "EBullet")&& !hit) {
			Health-=3;
			hit = true;
		}

	}
	// Update is called once per frame
	void Update () {
		if (iframes >= 1.0f && hit) {
			hit = false;
			iframes = 0.0f;
		}
		if (iframes != 1.0f && hit) {
			iframes = iframes + Time.deltaTime;

		} 
		Debug.Log(iframes);
		if (Health <= 0) {
			Destroy (gameObject); 
			UnityEngine.SceneManagement.SceneManager.LoadScene ("TitleScreen");
			}	
	//	Debug.Log(Health);
	}
}
