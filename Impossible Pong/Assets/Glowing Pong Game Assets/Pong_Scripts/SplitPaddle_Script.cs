using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitPaddle_Script : MonoBehaviour
{
    public GameObject split_paddle1;
    public GameObject split_paddle2;
    //public GameObject split_paddle3;

    public GameObject split_opponent_paddle1;
    public GameObject split_opponent_paddle2;
    //public GameObject split_opponent_paddle3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Pre-State
        if (collision.gameObject.CompareTag("Player 1"))
        {
            Destroy(collision.gameObject);
            Instantiate(split_paddle1);
            //Destroy(gameObject);

        }

        else if (collision.gameObject.CompareTag("Player 2"))
        {
            Debug.Log("Opponent Split");
            Destroy(collision.gameObject);
            Instantiate(split_opponent_paddle1);
            //Destroy(gameObject);
        }

        // Primary State

        else if (collision.gameObject.CompareTag("Player 1_1"))
        {
            Debug.Log("Player split agaain");
            Destroy(collision.gameObject);
            Instantiate(split_paddle2);
        }

        else if (collision.gameObject.CompareTag("Player 2_1"))
        {
            Debug.Log("Opponent split agaain");
            Destroy(collision.gameObject);
            Instantiate(split_opponent_paddle2);
        }


        //Secondary State

        // else if (collision.gameObject.CompareTag("Player 1_2"))
        // {
        //     Destroy(collision.gameObject);
        //     Instantiate(split_paddle3);
        // }

        // else if (collision.gameObject.CompareTag("Player 2_2"))
        // {
        //     Destroy(collision.gameObject);
        //     Instantiate(split_opponent_paddle3);
        // }
    }
}
