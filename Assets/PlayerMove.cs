using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool colW;
    private bool colA;
    private bool colS;
    private bool colD;
    

    private void Update()
    {
    
        
        if (Input.GetKeyDown(KeyCode.W) && !colW)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y +2, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.S) && !colS)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y -2, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.A) && !colA)
        {
            transform.position = new Vector3(transform.position.x - 2 , transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D) && !colD)
        {
            transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        }
        
    }
}
