using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthProgressBar : MonoBehaviour {

	public Transform healthProgressBar;
	[SerializeField] private float currentAmound;
	[SerializeField] private float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (currentAmound < 100) {
			currentAmound += speed * Time.deltaTime;

		} else {
			
		}
		healthProgressBar.GetComponent<Image>().fillAmount = currentAmound / 100;
	}
}
