using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitPaddle_Script : MonoBehaviour
{
    public GameObject pre_state_paddle;
    public GameObject split_paddle1;
    public GameObject split_paddle2;

    public GameObject pre_state_p2;
    public SpriteRenderer pre_state_p2_renderer;
    public BoxCollider2D pre_state_p2_collider;
    public GameObject split_p2_paddle1;
    public GameObject split_p2_paddle2;

    public GameObject pre_state_opponent;
    //public SpriteRenderer pre_state_opponent_renderer;
    //public GameObject split_opponent_paddle1;
    //public GameObject split_opponent_paddle2;

    public bool active = false;

    private void Start()
    {
        // grabs renderer of both the player 2 and opponent
        pre_state_p2_renderer.GetComponent<SpriteRenderer>();
        //pre_state_opponent_renderer.GetComponent<SpriteRenderer>();
        pre_state_p2_collider.GetComponent<BoxCollider2D>();


        // enable the player
        pre_state_paddle.SetActive(true);

        // sets first paddles to false
        split_paddle1.SetActive(false);
        split_p2_paddle1.SetActive(false);
        //split_opponent_paddle1.SetActive(false);

        // sets the second paddles to false
        split_paddle2.SetActive(false);
        split_p2_paddle2.SetActive(false);
        //split_opponent_paddle2.SetActive(false);
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
            active = true;

        }

        else if (collision.gameObject.CompareTag("Player 2"))
        {
            // if ball touches P2 --> set opponent to inactive
            // and set next opponent to active

            pre_state_p2_renderer.enabled = false;
            pre_state_p2_collider.enabled = false;
            split_p2_paddle1.SetActive(true);
        }

        else if (collision.gameObject.CompareTag("Split_Opponent"))
        {
            // if ball touches opponent --> set opponent to inactive
            // and set next opponent to active

            //pre_state_opponent_renderer.enabled = false;
            pre_state_p2_collider.enabled = false;
            //split_opponent_paddle1.SetActive(true);
        }

        // Primary State

        else if (collision.gameObject.CompareTag("Opponent_1"))
        {
            //&& activationScript.opponent_active == true
            //split_opponent_paddle1.SetActive(false);
            //split_opponent_paddle2.SetActive(true);
        }


        else if (collision.gameObject.CompareTag("Player 1_1"))
        {
            split_paddle1.SetActive(false);
            split_paddle2.SetActive(true);
        }


        else if (collision.gameObject.CompareTag("Player 2_1"))
        {
            //&& activationScript.opponent_active == false
            split_p2_paddle1.SetActive(false);
            split_p2_paddle2.SetActive(true);
        }

        // now if it is touching the goal post

        // player detection

        else if (collision.gameObject.CompareTag("Left Border") && split_paddle1.activeSelf)
        {
            // if player scores a point --> put them back a state
            split_paddle1.SetActive(false);
            pre_state_paddle.SetActive(true);
            Debug.Log("this works");
        }

        else if (collision.gameObject.CompareTag("Left Border") && split_paddle2.activeSelf)
        {

            // if player scores a point --> put them back a state
            split_paddle2.SetActive(false);
            split_paddle1.SetActive(true);
            Debug.Log("this works");
        }

        // p2 detection

        else if (collision.gameObject.CompareTag("Right Border") && split_p2_paddle1.activeSelf)
        {
            // if player scores a point --> put them back a state

            split_p2_paddle1.SetActive(false);
            pre_state_p2_renderer.enabled = true;
            pre_state_p2_collider.enabled = true;

        }

        else if (collision.gameObject.CompareTag("Right Border") && split_p2_paddle2.activeSelf)
        {
            // if player scores a point --> put them back a state
            split_p2_paddle2.SetActive(false);
            split_p2_paddle1.SetActive(true);

        }

        // only if you want to include opponent to be split

        //else if (collision.gameObject.CompareTag("Left Border") && split_opponent_paddle1.activeSelf)
        //{
        //    // if player scores a point --> put them back a state

        //    split_opponent_paddle1.SetActive(false);
        //    pre_state_opponent_renderer.enabled = true;
        //    pre_state_p2_collider.enabled = true;
        //}

        //else if (collision.gameObject.CompareTag("Left Border") && split_opponent_paddle2.activeSelf)
        //{
        //    // if player scores a point --> put them back a state
        //    split_opponent_paddle2.SetActive(false);
        //    split_opponent_paddle1.SetActive(true);
        //}
    }
}
