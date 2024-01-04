using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystem;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    public float Scrap;
    public Text ScrapText;



    void Start()
    {
        ScrapText.text = "Scrap:" + Scrap.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 5;
        shopItems[2, 2] = 10;
        shopItems[2, 3] = 10;
        shopItems[2, 4] = 10;

    }

    
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (Scrap >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            Scrap -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            ScrapText.text = "Scrap:" + Scrap.ToString();



        }

    }
}
