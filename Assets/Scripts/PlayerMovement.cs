using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//yasin
	
	// Update is called once per frame
	public int speed = 5;

	void FixedUpdate ()
	{
		if (transform.position.y > -2.0f) {
			if (Input.GetKey (KeyCode.A)) {
				transform.position += Vector3.left * speed * Time.deltaTime;
			}
			if (Input.GetKey (KeyCode.D)) {
				transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if (Input.GetKey (KeyCode.W)) {
				transform.position += Vector3.up * speed * Time.deltaTime;
			}
			if (Input.GetKey (KeyCode.S)) {
				transform.position += Vector3.down * speed * Time.deltaTime;
			}

			var pos = Camera.main.WorldToScreenPoint (transform.position);
			var dir = Input.mousePosition - pos;
			var angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		} else {
			transform.position = new Vector3(transform.position.x, -1.99f, transform.position.y);
		}
		 

	
	}
}
