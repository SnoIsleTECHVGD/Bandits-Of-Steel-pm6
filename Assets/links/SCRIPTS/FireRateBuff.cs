using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/FireRateBuff")]

public class FireRateBuff : PowerUpEffect
{
    public float amount;

    public override void Apply(GameObject shootPoint)
    {
        shootPoint.GetComponentInChildren<Shooting>().projectileCoolDown += amount;
    }
}
