﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKeys : MonoBehaviour {

    public float speed = 5.0f;
    public float speed2 = 10.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //keys
   
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
        }


        //wasd
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(speed2 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-speed2 * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -speed2 * Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, speed2 * Time.deltaTime,0));
        }
    }
}
