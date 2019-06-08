using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mov : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardF = 200f;

    void Start() { 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("d")){
            rb.AddForce(0, 0, forwardF * Time.deltaTime);
        }
        if(Input.GetKey("s")){
            rb.AddForce(forwardF * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a")){
            rb.AddForce(0, 0, -forwardF * Time.deltaTime);
        }
        if(Input.GetKey("w")){
            rb.AddForce(-forwardF * Time.deltaTime, 0, 0);
        }
    }
}
