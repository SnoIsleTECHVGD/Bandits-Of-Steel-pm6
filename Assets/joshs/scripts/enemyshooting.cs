using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{
    public  GameObject bullet;
        public Transform bulletpos;
    public float distance;
    public float distanceBetween;
    private float timer;
    public GameObject npc;
    // Start is called before the first frame update
    void Start()
    {
        npc = GameObject.Find("npc");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, npc.transform.position);
        Vector2 direction = npc.transform.position - transform.position;
        direction.Normalize();

        if (distance < distanceBetween)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
        }

    }
    void shoot()
    {
        Instantiate(bullet, bulletpos.position, Quaternion.identity);
    }
}
