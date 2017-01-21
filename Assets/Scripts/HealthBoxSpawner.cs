using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoxSpawner : MonoBehaviour {

	public GameObject healthBox;
	public float delay = 100f;

	// Use this for initialization
	void Start () {
		StartCoroutine(Update());
	}
	
	// Update is called once per frame
	IEnumerator Update () {
		Instantiate (healthBox, transform.position, transform.rotation);
		yield return new WaitForSeconds(delay);
		StartCoroutine(Update());
	}


		
}
