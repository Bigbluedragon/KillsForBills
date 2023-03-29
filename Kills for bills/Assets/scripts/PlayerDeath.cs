using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour


{
    public GameObject gameOverUI;
    private bool isDead;
    public gameManagerScript gameManager;
    private Rigidbody2D rb;
    private void Start()

    
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap") && !isDead)
        {
            isDead = true;
            Die();
            Debug.Log("youre dead");
            gameOverUI.SetActive(true);      
                            
                       
    
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        
    }
}