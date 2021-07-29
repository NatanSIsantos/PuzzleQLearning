using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerColetaveis : MonoBehaviour
{
    public int player = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            player += 1;
            other.GetComponent<SpriteRenderer>().enabled = false;
            other.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log(player);
        }
    }
    
}
