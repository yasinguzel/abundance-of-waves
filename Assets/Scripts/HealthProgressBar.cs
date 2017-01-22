using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthProgressBar : MonoBehaviour {

	public Transform healthProgressBar;
	public float healthValue = GameObject.Find ("Player").GetComponent<HumanPlayer> ().Health;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		healthValue = GameObject.Find ("Player").GetComponent<HumanPlayer> ().Health;
		healthProgressBar.GetComponent<Image>().fillAmount = healthValue;

	}
}
