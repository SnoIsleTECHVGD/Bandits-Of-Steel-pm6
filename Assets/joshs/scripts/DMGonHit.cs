
using UnityEngine;
[RequireComponent(typeof(stats))]
public class DMGonHit : MonoBehaviour
{
    private void OnColliderEnter2D (Collision2D collision)
    {
        stats hitStats = collision.gameObject.GetComponent<stats>();
        stats ourStats = GetComponent<stats>();

        if (hitStats  != null)
        {
            hitStats.health -= ourStats.attack - hitStats.defence;

            if (hitStats.health<= 0)
            {
                Destroy(hitStats.gameObject);
            }
        }
        
    }
   
}

