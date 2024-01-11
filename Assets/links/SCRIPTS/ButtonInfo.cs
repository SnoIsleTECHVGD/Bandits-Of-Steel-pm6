using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public Text PriceText;
    public GameObject ShopManager;

    void Start()
    {
        PriceText.text = "Price: 5" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
    }
}
