using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float inputHorizontal;
    private float inputVertical;
    private Transform playerSprite;
    [SerializeField]private Transform verticalMove;
    [SerializeField]private Transform horizontalMove;

    void Start()
    {
        verticalMove.transform.position = gameObject.transform.GetChild(0).position;
        horizontalMove.transform.position = gameObject.transform.GetChild(1).position;
        Debug.Log(verticalMove.transform.position);
        Debug.Log(horizontalMove.transform.position);
    }
}
