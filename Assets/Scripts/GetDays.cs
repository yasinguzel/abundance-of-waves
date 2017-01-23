using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GetDays : MonoBehaviour {

	public static int getDays = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevel == 2)
			getDays = GetComponent<DayCounter> ().getDay ();
	}

	public int getDaysF(){
		return getDays;
	}
}
