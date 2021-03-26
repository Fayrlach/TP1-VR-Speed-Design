﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    float inputX, inputZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        if (inputX != 0)
            rotate ();
        if (inputZ != 0)
            move ();

    }
    private void rotate (){
        transform.Rotate(new Vector3(0F, 32*inputX*Time.deltaTime, 0F));
    }
    private void move (){
        transform.position += transform.forward * inputZ * Time.deltaTime * 4;
    }
}
