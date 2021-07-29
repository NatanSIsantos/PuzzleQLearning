using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject coin2;
    private PlayerColetaveis pontos;
    private void Start()
    {
        pontos = FindObjectOfType<PlayerColetaveis>();
    }

    
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            transform.position = new Vector3(-3, -3, 0);
            
            coin.GetComponent<SpriteRenderer>().enabled = true;
            coin.GetComponent<BoxCollider2D>().enabled = true;

            coin2.GetComponent<SpriteRenderer>().enabled = true;
            coin2.GetComponent<BoxCollider2D>().enabled = true;

            pontos.player = 0;

        }

        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("Saiu!!!");
        }
    }
}
