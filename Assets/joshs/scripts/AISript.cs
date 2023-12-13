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
//  [SerializeField] float range;
//  [SerializeField] float maxDistance;
 // Vector2 wayPoint;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");

    //  SetNewDestination();
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
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed *Time.deltaTime);
           //  transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }

      //transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
       //f (Vector2.Distance(transform.position, wayPoint) < range)
     // {
     //     SetNewDestination();
      //}

    }
  //void SetNewDestination()
 // {
  //    wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
  //}
}
