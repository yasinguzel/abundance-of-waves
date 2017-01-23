using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

	public int healthAddValue = 1;
	public int foodAddValue = 1;
	public int waterAddValue = 1;
	public int bulletAddValue = 1;

	HumanPlayer myPlayer;


	// Use this for initialization
	void Start () {
		myPlayer = GetComponent<HumanPlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "HealthBox"){

			myPlayer.SetHealth (healthAddValue);
		}
		if(coll.gameObject.tag == "FoodBox"){

			myPlayer.SetFood (foodAddValue);
		}
		if(coll.gameObject.tag == "WaterBox"){

			myPlayer.SetWater(waterAddValue);
		}
		if(coll.gameObject.tag == "BulletBox"){
			
			GameObject.Find ("Player").GetComponent<PlayerShooter> ().Bullet += bulletAddValue;

		}

	}
}
