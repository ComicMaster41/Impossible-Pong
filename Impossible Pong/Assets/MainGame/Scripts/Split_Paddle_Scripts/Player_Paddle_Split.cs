using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Paddle_Split : MonoBehaviour
{
    public GameObject split_paddle1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Pre-State
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            Instantiate(split_paddle1);
            //Destroy(gameObject);

        }
    }
}
