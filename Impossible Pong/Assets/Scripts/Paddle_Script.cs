using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_Script : MonoBehaviour
{
    public bool player;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPos;

    private float movement;

    private void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (player)
        {
            movement = Input.GetAxisRaw("Vertical");
        }

        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
}
