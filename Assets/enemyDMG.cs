using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDMG : MonoBehaviour
{
    private void OncollisionEnter2D(Collider2D collision)
    {
        stats HitStats = collision.gameObject.GetComponent<stats>();
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<stats>().currentHealth -= 30;



        }

    }
}