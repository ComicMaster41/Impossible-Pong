using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Spawn_Script_P2 : MonoBehaviour
{
    public GameObject ball_1;

    public GameObject ball_2;

    //public BallMovement ballMovement;

    public int ball_counter = 0;

    public bool ball_multiplied = false;



    private void Start()
    {
        // set the opponents and the balls to false

        ball_1.SetActive(false);
        ball_2.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if ball_count is greater than ball_limiter --> spawn
        // begin launch/reset function
        //StartCoroutine(ballMovement.Launch());
        if (collision.gameObject.name == "Left Border" && ball_counter == 0)
        {
            ball_multiplied = true;
            ball_counter++;
        }

        else if (collision.gameObject.name == "Left Border" && ball_counter == 1)
        {
            ball_1.SetActive(true);
            ball_counter++;
        }

        else if (collision.gameObject.name == "Left Border" && ball_counter == 2)
        {
            ball_2.SetActive(true);
        }

        // reverse logic
        if (collision.gameObject.name == "Right Border" && ball_counter == 0)
        {
            return;
        }

        // if counter 1, set ball 1 false and ball 0 true
        // if counter 2, set ball 2 false and ball 1 true

        else if (collision.gameObject.name == "Right Border" && ball_counter == 1)
        {
            ball_1.SetActive(false);
            ball_counter--;
        }

        else if (collision.gameObject.name == "Right Border" && ball_counter == 2)
        {
            ball_1.SetActive(true);
            ball_counter--;
            ball_2.SetActive(false);
        }
    }
}
