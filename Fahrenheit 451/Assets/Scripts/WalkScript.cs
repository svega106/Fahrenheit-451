﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WalkScript : MonoBehaviour
{
    private float speed = 5f;

    public Rigidbody rb;

    public Animator animator;
    Vector3 movement;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
        movement.y = 0;
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.z);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }


}
