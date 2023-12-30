using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    public float speed = 8f;
    public float jumpingPower = 8f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private AudioSource jumpSoundEffect;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            jumpSoundEffect.Play();
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

// Growth Ability (Seperate files were not working)
        if (Item.canGrow == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                transform.localScale = new Vector3(2, 2, 0);
                speed = 6f;
                jumpingPower = 12f;
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                transform.localScale = new Vector3(1, 1, 0);             
                speed = 8f;
                jumpingPower = 8f;
            }
        }
// Shrink Ability (Seperate files were not working)
        if (Item.canShrink == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0);
                speed = 12f;
                jumpingPower = 6f;
            }

            if (Input.GetKeyUp(KeyCode.LeftControl))
            {
                transform.localScale = new Vector3(1f, 1f, 0);
                speed = 8f;
                jumpingPower = 8f;
            }
        }
        

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}


// public class GrowthAbility : MonoBehaviour
//     {
//         // PlayerMovement movement = new PlayerMovement();
//         public bool bigMode;

//         void Update()
//         {
            
//         }
//     }