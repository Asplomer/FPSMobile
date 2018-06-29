using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void OnClick()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("PlayGround1");
	}

	public void OnClose()
	{
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
