using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

	public float healthAddValue = 1;
	public float foodAddValue = 1;
	public float waterAddValue = 1;
	public float bulletAddValue = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "HealthBox"){
			GameObject.Find ("Player").GetComponent<HumanPlayer> ().Health += healthAddValue;
			Debug.Log ("Health: "+GameObject.Find ("Player").GetComponent<HumanPlayer> ().Health);
		}
		if(coll.gameObject.tag == "FoodBox"){
			GameObject.Find ("Player").GetComponent<HumanPlayer> ().Food += foodAddValue;
			Debug.Log ("Food: "+GameObject.Find ("Player").GetComponent<HumanPlayer> ().Food);
		}
		if(coll.gameObject.tag == "WaterBox"){
			GameObject.Find ("Player").GetComponent<HumanPlayer> ().Water += waterAddValue;
			Debug.Log ("Water: "+GameObject.Find ("Player").GetComponent<HumanPlayer> ().Water);
		}
		if(coll.gameObject.tag == "BulletBox"){
			GameObject.Find ("Player").GetComponent<PlayerShooter> ().Bullet += bulletAddValue;
			Debug.Log ("Bullet: "+GameObject.Find ("Player").GetComponent<PlayerShooter> ().Bullet);
		}

	}
}
