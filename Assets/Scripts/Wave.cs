using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {
  public  Vector3 beginPos;
  public  Vector3 endPos;
  public float speed = 2;
  public GameObject healthBox;	
	public bool isUp = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (isUp) {
			if (this.transform.position.y < endPos.y) {
				this.transform.Translate (Vector3.up * Time.deltaTime * speed);
			} else {
				isUp = false;
			}
		} else {
			if (this.transform.position.y > beginPos.y) {
				this.transform.Translate (Vector3.down * Time.deltaTime * speed);
			} else {
				isUp = true;
			}
		}

    }

}
