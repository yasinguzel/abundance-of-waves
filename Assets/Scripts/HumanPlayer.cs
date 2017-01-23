using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HumanPlayer : MonoBehaviour {
	  
	public Image[] sliders;


    public float Food = 100;
    public float Health = 100;
    public float Water = 100;

	public float FoodMAX = 100;
	public float HealthMAX = 100;
	public float WaterMAX = 100;


	public int negativeFood = -1;
	public int negativeWater = -1;

	public float delayFood = 5;
	public float delayWater = 6;

	public float dieFood = 5;
	public float dieWater = 5;

	public int dieFoodM = -1;
	public int dieWaterM = -2;

	public bool isGo = false;
	public bool isGoW = false;



	public void SetHealth(int _value){
		if (this.Health + _value <= 0) {
			Health = 0;
			Die ();
		}
		else if (this.Health + _value >= HealthMAX) {
			this.Health = this.HealthMAX;
		}
		else
			this.Health += _value;

		sliders [0].fillAmount = this.Health / this.HealthMAX;
			
	}
	public void SetFood(int _value){
		//6 sn 1 azalacak
		if (this.Food + _value <= 0) {
			Food = 0;
			//5 snde bir
			StartCoroutine(dieFoodP());


		}

		else if (this.Food + _value >= FoodMAX) {
			this.Food = this.FoodMAX;
		}
		else
			this.Food += _value;

		sliders [1].fillAmount = this.Food / this.FoodMAX;

	}
	public void SetWater(int _value){
		//6 sn 1 azalacak
		if (this.Water + _value <= 0) {
			Water = 0;
			StartCoroutine(dieWaterP());
		}
		else if (this.Water + _value >= WaterMAX) {
			this.Water = this.WaterMAX;
		}
		else
			this.Water += _value;

		sliders [2].fillAmount = this.Water / this.WaterMAX;

	}

    void Update()
    {
		if(!isGo)
			StartCoroutine(timeMinusFood ()); isGo = true;
		if(!isGoW)
			StartCoroutine(timeMinusWater ()); isGoW = true;


    }

	IEnumerator timeMinusFood(){


		for (;;) {
			yield return new WaitForSeconds(delayFood);
			SetFood (negativeFood);
		}


	}

	IEnumerator timeMinusWater(){


		for (;;) {
			yield return new WaitForSeconds(delayWater);
			SetWater (negativeWater);
		}


	}

	IEnumerator dieFoodP(){

		for (;;) {
			yield return new WaitForSeconds(dieFood);
			if(Food == 0)
				SetHealth (dieFoodM);
		}


	}

	IEnumerator dieWaterP(){

		for (;;) {
			yield return new WaitForSeconds(dieWater);
			if(Water == 0)
				SetHealth (dieWaterM);
		}


	}
		
    void Die()
    {
		SceneManager.LoadScene(3);


    }

}
