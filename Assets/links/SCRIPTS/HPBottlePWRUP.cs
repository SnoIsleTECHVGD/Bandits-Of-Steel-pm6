using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public abstract class HPBottlePWRUP : MonoBehaviour
{
    public abstract string GiveName();

    public virtual void Update(Player player, int stacks)
    {

    }
}

public class HPBottle : Item
{

    public override string GiveName()
    {
        return "HPBottle";
    }

    public virtual void Update(Player player, int stacks)
    {
        player.health += 50;
    }



}
