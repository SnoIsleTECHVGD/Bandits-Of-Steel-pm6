using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SpeedBuff")]

public class SpeedBuff: PowerUpEffect
{
    public float amount;

    public override void Apply(GameObject Player)
    {
        Player.GetComponent<PlayerMove>().buildUp += amount;
    }

}
