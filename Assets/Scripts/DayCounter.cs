using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCounter : MonoBehaviour {

	public float Timer = 0.0f;
	public static int day = 1;
	public bool isTime = false;
	public float dayTime = 30;

	// Use this for initialization
	void Start () {
		day = 1;
		GetComponent<Text> ().text = "Day " + day.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		if(!isTime)
			StartCoroutine(dayCount()); isTime = true;
		
		GetComponent<Text> ().text = "Day " + day.ToString();


			
	}

	IEnumerator dayCount(){
		for (;;) {
			
			yield return new WaitForSeconds(dayTime-=day);
			Debug.Log ("daytime:"+dayTime);
			Debug.Log ("daytime:"+day);

			day++;
		}

	}

	public int getDay(){
		return day;
	}

		



}
