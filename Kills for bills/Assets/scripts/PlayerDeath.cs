using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour


{
    public static event Action OnPlayerDeath;
    
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            Die();
            Debug.Log("youre dead");
            

        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        
    }
}