using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator anim;
    public float moveSpeed;
    public float x, y;
    private bool IsMoving;
    private Vector3 moveDir;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (x != 0 || y != 0)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);
            if (!IsMoving)
            {
                IsMoving = true;
                anim.SetBool("IsMoving", IsMoving);
            }
            else
            {
                if (IsMoving)
                {
                    IsMoving = false;
                    anim.SetBool("IsMoving", IsMoving);
                    StopMoving();
                }
            }
            moveDir = new Vector3(x, y).normalized;
        }
        void FixedUpdate()
        {
            rb.velocity = moveDir * moveSpeed * Time.deltaTime;
        }
        void StopMoving()
        {
            rb.velocity = Vector3.zero;
        }
    }

}