﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool DebugMovement;
    public int Speed;
    private int FramesCollidedWithTerrian;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.GetComponent<CapsuleCollider>().enabled && //if grounded)
        //{
        //
        //
        //}

        DebugWASD();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<TerrainCollider>().enabled) //other.tag == "collision tag name"
        {
            FramesCollidedWithTerrian++;
        }
        else
        {
            FramesCollidedWithTerrian = 0;
        }
    }

    void DebugWASD()
    {
        if (DebugMovement)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.GetComponent<Rigidbody>().AddForce(Vector3.forward * Speed);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.GetComponent<Rigidbody>().AddForce(Vector3.left * Speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.GetComponent<Rigidbody>().AddForce(Vector3.back * Speed);

            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.GetComponent<Rigidbody>().AddForce(Vector3.right * Speed);
            }
        }
    }
}
