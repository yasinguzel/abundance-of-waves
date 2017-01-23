using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSurvivedDays : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//You Survived 0 Days

		GetComponent<Text>().text = "You Survived "+GameObject.Find ("Canvas/Day/DayText").GetComponent<DayCounter> ().getDay () +" Days";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
