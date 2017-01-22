using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHealth : MonoBehaviour {

	private float destroyTime = 13f;
	public GameObject colloctedObject;
	public int day;

	// Use this for initialization
	void Start () {
		day = GameObject.Find ("Canvas/Day/DayText").GetComponent<DayCounter> ().getDay ();
	}
	
	// Update is called once per frame
	void Update () {
		destroyTime -= day;
		Destroy (gameObject, destroyTime);
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			Destroy (gameObject, 0);
			Instantiate (colloctedObject, transform.position, transform.rotation);

		}
	}

	public float GetDestroyTime(){
		return destroyTime;
	}

	public void SetDestroyTime(float time){
		destroyTime = time;
	}
}
