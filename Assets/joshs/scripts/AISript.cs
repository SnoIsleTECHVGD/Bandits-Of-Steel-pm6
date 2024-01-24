using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISript : MonoBehaviour
{
    public GameObject player;
    public float speed;
   
    private float distance;
    public float distanceBetween;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
      

        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        




        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
           
        }
    }
}
