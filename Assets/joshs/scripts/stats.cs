using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    public int health;
    public int attack;
     public int defence;
    public float speed;
    private float bulletForce;
    public List<ItemList> items = new List<ItemList>();

    void Start()
    {
        HealingItem item = new HealingItem();
        items.Add(new ItemList(item, item.GiveName(), 1));
        StartCoroutine(CallItemUpdate());
    }

    void Update()
    {
        
    }

    IEnumerator CallItemUpdate()
    {
        foreach (ItemList i in items)
        {
            i.item.Update(this, i.stacks);
        }
        yield return new WaitForSeconds(1);
        StartCoroutine(CallItemUpdate());
    }
}

