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
    public SpriteRenderer pre_state_opponent_renderer;
    public GameObject split_opponent_paddle1;
    public GameObject split_opponent_paddle2;
    //public GameObject split_opponent_paddle3;

    private void Start()
    {
        pre_state_opponent_renderer.GetComponent<SpriteRenderer>();

        pre_state_paddle.SetActive(true);

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
            // if ball touches player 1 --> set player inaactive
            // and set next player to active

            pre_state_paddle.SetActive(false);
            split_paddle1.SetActive(true);

        }

        else if (collision.gameObject.CompareTag("Player 2"))
        {
            // if ball touches P2 --> set opponent to inactive
            // and set next opponent to active

            pre_state_opponent_renderer.enabled = false;
            split_opponent_paddle1.SetActive(true);
        }

        // Primary State

        else if (collision.gameObject.CompareTag("Player 1_1"))
        {
            split_paddle1.SetActive(false);
            split_paddle2.SetActive(true);
        }

        else if (collision.gameObject.CompareTag("Player 2_1"))
        {
            split_opponent_paddle1.SetActive(false);
            split_opponent_paddle2.SetActive(true);
        }

        // now if it is touching the goal post

        else if (collision.gameObject.CompareTag("Right Border") && split_paddle1.activeSelf)
        {
            // if player scores a point --> put them back a state

            Debug.Log("this new code works");
            split_paddle1.SetActive(false);
            pre_state_paddle.SetActive(true);
        }

        else if (collision.gameObject.CompareTag("Right Border") && split_paddle2.activeSelf)
        {

            // if player scores a point --> put them back a state

            Debug.Log("this new code works");
            split_paddle2.SetActive(false);
            split_paddle1.SetActive(true);
        }

        else if (collision.gameObject.CompareTag("Left Border") && split_opponent_paddle1.activeSelf)
        {
            // if player scores a point --> put them back a state

            Debug.Log("this new code works");
            split_opponent_paddle1.SetActive(false);
            pre_state_opponent_renderer.enabled = true;
        }

        else if (collision.gameObject.CompareTag("Left Border") && split_opponent_paddle2.activeSelf)
        {
            // if player scores a point --> put them back a state
            split_opponent_paddle2.SetActive(false);
            split_opponent_paddle1.SetActive(true);
        }
    }
}
