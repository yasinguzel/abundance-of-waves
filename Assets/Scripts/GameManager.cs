using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement ;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
  
  public Image fadeMask;

  private bool starting = false;
  private float fadeTime;
	// Use this for initialization
	void Start () {
		starting = false;
    fadeTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
    if (starting)
    {
      if(fadeTime < 1)
      {
        fadeTime += Time.deltaTime;
        fadeMask.color = new Color(0,0,0,fadeTime);
      }
      else
      {
        SceneManager.LoadScene(2);
      }
    }
	}

  public void startButtonPressed()
  {
  Debug.Log("adad");
    starting = true;
  }
}
