using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {
  public  Vector3 beginPos;
  public  Vector3 endPos;
  public float speed = 2;
  public GameObject healthBox;
  Animator anim;
  SpriteRenderer render;

	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer>();
	    anim = GetComponent<Animator>();
	    anim.SetTrigger("dalga");
	}
	
	// Update is called once per frame
	void Update () {


    if (this.transform.position.y < endPos.y)
    {
        this.transform.Translate(Vector3.up*Time.deltaTime*speed);
		
    }
    else
    {

		this.transform.position = beginPos;
		anim.SetTrigger("dalga");
		for (int i = 0; i <= 6; i++) {
			Instantiate (healthBox, new Vector3(Random.Range(-9.33f,9.33f),transform.position.y,transform.position.z), transform.rotation);	
		}

    }
	}
}
