using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HumanPlayer : MonoBehaviour {

    public float Food = 100;
    public float Health = 100;
    public float Water = 100;

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
