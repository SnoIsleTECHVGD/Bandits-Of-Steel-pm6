using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletS : MonoBehaviour
{
    private GameObject enemy;
    private Rigidbody2D rb;
   



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { stats HitStats = collision.gameObject.GetComponent<stats>();
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.GetComponent<stats>().health -= 10;

           

        }

        if (HitStats.health <= 0)
        {
           Destroy (HitStats.gameObject);
        }
    }
   
}

