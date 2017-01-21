using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour {
	public  Vector3 beginPos;
	public  Vector3 endPos;
	public float speed = 2;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		if (this.transform.position.y < endPos.y)
		{
			this.transform.Translate(Vector3.up*Time.deltaTime*speed);
		}

	}
}
