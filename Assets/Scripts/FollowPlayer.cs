using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		/*Vector3 dir = GameObject.Find("Player").transform.position - transform.position;
		var angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);*/

	}
	
	// Update is called once per frame
	void Update () {
		//değdiği her snde iki
		Vector2 toTarget = GameObject.Find("Player").transform.position - transform.position;
		float speed = 1.5f;

		transform.Translate(toTarget * speed * Time.deltaTime);
	}
}
