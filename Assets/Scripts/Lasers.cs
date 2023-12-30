using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NewBehaviourScript;

public class Lasers : MonoBehaviour
{
    Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (NewBehaviourScript.invincible != true)
        {
            if (collision.CompareTag("Obstacle"))
            {
                Die();
            }
        }
    }

    void Die()
    {
        Respawn();
    }
    void Respawn()
    {
        transform.position = startPos;
    }
}
