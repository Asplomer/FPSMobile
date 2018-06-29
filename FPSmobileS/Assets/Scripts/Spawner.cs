using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public int foeCount;
	public int MaxFoe;
	public float timer;
	private Vector3 SpawnArea;
	void Start () {
		foeCount = 2;
		MaxFoe = 2;
//		Random.InitState();
	}
	public void Spawn(GameObject Creature, Vector3 Area){
		Instantiate (Creature, this.transform.position, this.transform.rotation);
		foeCount++;
	}

	// Update is called once per frame
	void Update () {/*
		if(foeCount !=MaxFoe){
			SpawnArea = Random.insideUnitSphere;
			transform.position.Set (SpawnArea.x, 0.0f, SpawnArea.z);


		}*/
	}
}
