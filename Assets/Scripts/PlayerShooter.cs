using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour {

	public PlayerShoot bullet;
	public Transform barrel;
	public float spawnDistance = 20;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector3 playerPos = barrel.transform.position;
			Vector3 playerDirection = barrel.transform.forward;
			Quaternion playerRotation = barrel.transform.rotation;


			Vector3 spawnPos = playerPos + playerDirection*spawnDistance;

			Instantiate(bullet, spawnPos, playerRotation );
		}


	}
}
