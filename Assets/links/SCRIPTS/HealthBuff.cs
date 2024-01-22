using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/HealthBuff")]

public abstract class HealthBuff : PowerUpEffect
{
    public float amount;

    public override void Apply(GameObject Player)
    {
        Player.GetComponent<stats>().health.value += amount;
    }




}
