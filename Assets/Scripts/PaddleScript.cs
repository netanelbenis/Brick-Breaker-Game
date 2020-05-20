﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=Input.GetAxis("Horizontal");
        if(x<0)
        {
            MoveLeft();
        }
        else if (x>0)
        {
            MoveRight();
        }
        else 
        Stop();

        Vector3 pos=transform.position;
        pos.x=Mathf.Clamp(pos.x,-maxX,maxX);
        transform.position=pos;
    }

    void MoveLeft(){
        rb.velocity=new Vector2(-speed,0);
    }

    void MoveRight(){
        rb.velocity=new Vector2(speed,0);
    }

    void Stop(){
        rb.velocity= Vector2.zero;
    }
}
