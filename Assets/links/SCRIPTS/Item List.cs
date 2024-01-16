using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class ItemList : MonoBehaviour
{
    public Item item;
    public string name;
    public int stacks;

    public ItemList(ItemList newItem, string newName, int newStacks)
    {
        item = newItem;
        name = newName;
        stacks = newStacks;
    }
}
