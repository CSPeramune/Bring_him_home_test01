using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float xDifference;
    public float zDifference;
    public float movementThreshold = 5f;

    void FixedUpdate()
    {
        /*if(target.transform.position.x > transform.position.x){
            xDifference = target.transform.position.x - transform.position.x;
        }
        else{
            xDifference = transform.position.x - target.transform.position.x;
        }
        if(target.transform.position.z > transform.position.z){
            zDifference = target.transform.position.z - transform.position.z;
        }
        else{
            zDifference = transform.position.z - target.transform.position.z;
        }
        
        if(xDifference >= movementThreshold || zDifference >= movementThreshold){*/
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        //transform.LookAt(target);
       //}
    }
}
