using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public float speed = 19f;
	public float destoryTime = 9f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, destoryTime);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.right * Time.deltaTime * speed);
	}

	void OnTriggerEnter2D(Collider2D coll){
	
		if (coll.gameObject.tag == "BugBox") {
			Destroy (gameObject, 0);
		}
	}
}
