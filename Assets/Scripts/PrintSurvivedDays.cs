using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintSurvivedDays : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "You Survived "+GetComponent<GetDays>().getDaysF()+" Days";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
