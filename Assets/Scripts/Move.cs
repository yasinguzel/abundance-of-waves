using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.up * 0.2f);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.Rotate (0, 0, -90);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			transform.Rotate (0, 0, 90);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector2.up * 0.2f);
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.Rotate (0, 0, 90);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			transform.Rotate (0, 0, -90);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector2.up * 0.2f);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector2.up * 0.2f);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.Rotate (0, 0, 180);
		}

		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			transform.Rotate (0, 0, -180);
		}
	}
}
