using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;




public class PlayerController : MonoBehaviour
{

    [SerializeField] float torqueAmount = 20.0f;
    [SerializeField] float boostSpeed = 30.0f;
    [SerializeField] float normalSpeed = 20.0f;


    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2d = FindAnyObjectByType<SurfaceEffector2D>();
    }


    void Update()
    {
        RotatePlayer();
        RespondToBoost();

    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2d.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2d.speed = normalSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
