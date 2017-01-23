using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBullet : MonoBehaviour {

	public float healt = 5f,minus=1f;
	public Animator hitAnim;
	public int damage = -1;
	public bool isEnter = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (healt == 0)
			Destroy (gameObject, 0);
	}

	void OnTriggerEnter2D(Collider2D coll){

		if (coll.gameObject.CompareTag("Bullet")) {
			healt -= minus;
			hitAnim.SetTrigger ("isHitted");
		}

	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.CompareTag("Player")) {
			GameObject.Find ("Player").GetComponent<HumanPlayer> ().SetHealth (damage);
		}

	}
		
}
