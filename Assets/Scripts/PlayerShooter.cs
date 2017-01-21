using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour {

	public PlayerShoot we;
	public Transform namlu;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Instantiate (we, namlu.transform.position, namlu.transform.rotation);
		}


	}
}
