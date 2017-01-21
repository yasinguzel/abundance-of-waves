using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

	public float healthAddValue = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "HealthBox"){
			GameObject.Find ("Player").GetComponent<HumanPlayer> ().Health += healthAddValue;
			Debug.Log (GameObject.Find ("Player").GetComponent<HumanPlayer> ().Health);
		}
	}
}
