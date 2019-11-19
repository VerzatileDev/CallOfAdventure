﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    //This code moves the enemies towards the player in game
    GameObject player;
    Rigidbody2D rb;
    public float Vision = 3f;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    void FixedUpdate()
    {

        

        //Finds the player
		player = GameObject.FindGameObjectWithTag("Player");
        //Pushes the object towards the player so long as the player gets close
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= Vision)

                {
                Vector2 directionOfForce = player.transform.position - transform.position;
                directionOfForce = directionOfForce.normalized;

                rb.AddForce(directionOfForce * 2f);
                rb.velocity = Vector2.ClampMagnitude(rb.velocity, 2f);
                }
        
    }

}




