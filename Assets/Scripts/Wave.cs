using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {
  	public  Vector3 beginPos;
  	public  Vector3 endPos;
 	public float speed = 2;
	public GameObject[] spawn;
	public int boxCount = 6;

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
				makeBox();
			}
		}

    }

	void makeBox(){
		int[] array={-8,-5,-2,1,4,7}; //Gün sayısı değiştikçe eleman sayısı artacak(Geçerli değerlerden)

		for (int i = 0; i < boxCount; i++) {
			Instantiate (spawn[Random.Range(0,5)], new Vector3 (array [Random.Range (0, 6)], transform.position.y, transform.position.z), transform.rotation);
			}
		}


}


