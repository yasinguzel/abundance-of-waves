using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public float speed = 5f;
	public float destoryTime = 1f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, destoryTime);
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.right * Time.deltaTime * speed);
	}

	void OnCollisionEnter2D(Collision2D coll){
	
		if (coll.gameObject.tag == "enemy") {
			Debug.Log ("Enemy Görüldü");
		}
	}
}
