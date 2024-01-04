using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int Scrap;
    public int HP;
    public Text Scrap_text;
    public Text HP_text;


    void Start()
    {
        
    }

    public void BuyHP()
    {
        if(Scrap >= 5)
        {
            Scrap -= 5;
            Scrap_text.text = Scrap_ToString();

            HP += 1;
            HP_text.text = HP_ToString();
        }
        else
        {
            print("Not enough Scrap")
        }
    }

   
}
