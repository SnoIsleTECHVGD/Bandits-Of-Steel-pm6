using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Control : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Run Down");
        }
    }

 
}
