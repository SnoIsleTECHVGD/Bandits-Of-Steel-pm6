using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISript : MonoBehaviour
{
    public GameObject player;
    public float speed;
    // public Animator animator;
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
       // animator.SetFloat("speed", distance);

        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


      

        if(distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed = Time.deltaTime);
           //  transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
