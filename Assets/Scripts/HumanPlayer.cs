using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HumanPlayer : MonoBehaviour {
	  
	public Image[] sliders;


    public float Food = 100;
    public float Health = 100;
    public float Water = 100;

	public float FoodMAX = 100;
	public float HealthMAX = 100;
	public float WaterMAX = 100;


	public void SetHealth(float _value){
		if (this.Health + _value < 0) {
			Health = 0;
			Die ();
		}
		if (this.Health + _value >= HealthMAX) {
			this.Health = this.HealthMAX;
		}
		else
			this.Health += _value;

		sliders [0].fillAmount = this.Health / this.HealthMAX;
			
	}


    void Update()
    {
        ImHuman();
    }

    void ImHuman()
    {
        if (Health < 0) Die();
        if (Water < 0) Thirsty();
        if (Food < 0) Starve();
    }

    void Starve()
    {



    }

    void Thirsty()
    {


    }

    void Die()
    {



    }

}
