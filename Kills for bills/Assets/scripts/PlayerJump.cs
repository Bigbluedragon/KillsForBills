using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] int jumpPower;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;


    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }

    
    void Update()
    {

        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(1.07f, 0.91f), CapsuleDirection2D.Vertical, 0, groundLayer);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        
    }
}