using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y + 2 <= 3) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y +2, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.S) && transform.position.y - 2 >= -3)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y -2, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x - 2 >= -3)
        {
            transform.position = new Vector3(transform.position.x - 2 , transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x + 2 <= 3)
        {
            transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        }
        
    }
}
