using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitPaddle_Script : MonoBehaviour
{
    public GameObject pre_state_paddle;
    public GameObject split_paddle1;
    public GameObject split_paddle2;
    //public GameObject split_paddle3;

    public GameObject pre_state_opponent;
    public GameObject split_opponent_paddle1;
    public GameObject split_opponent_paddle2;
    //public GameObject split_opponent_paddle3;

    private void Start()
    {
        pre_state_paddle.SetActive(true);
        pre_state_opponent.SetActive(true);

        split_paddle1.SetActive(false);
        split_opponent_paddle1.SetActive(false);

        split_paddle2.SetActive(false);
        split_opponent_paddle2.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Pre-State
        if (collision.gameObject.CompareTag("Player 1"))
        {
            //Destroy(collision.gameObject);
            //Instantiate(split_paddle1);

            //Destroy(gameObject);

            // if ball touches player 1 --> set player inaactive
            // and set next player to active

            pre_state_paddle.SetActive(false);
            split_paddle1.SetActive(true);

        }

        else if (collision.gameObject.CompareTag("Player 2"))
        {
            //Debug.Log("Opponent Split");
            //Destroy(collision.gameObject);
            //Instantiate(split_opponent_paddle1);
            //Destroy(gameObject);

            // if ball touches P2 --> set opponent to inactive
            // and set next opponent to active

            pre_state_opponent.SetActive(false);
            split_opponent_paddle1.SetActive(true);
            Debug.Log("opponent got to the first state");

        }

        // Primary State

        else if (collision.gameObject.CompareTag("Player 1_1"))
        {
            //Debug.Log("Player split agaain");
            //Destroy(collision.gameObject);
            //Instantiate(split_paddle2);

            split_paddle1.SetActive(false);
            split_paddle2.SetActive(true);
        }

        else if (collision.gameObject.CompareTag("Player 2_1"))
        {
            //Debug.Log("Opponent split agaain");
            //Destroy(collision.gameObject);
            //Instantiate(split_opponent_paddle2);

            split_opponent_paddle1.SetActive(false);
            split_opponent_paddle2.SetActive(true);
            Debug.Log("opponent got to the second state");
        }
    }
}
