using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Spawn_Script_P2 : MonoBehaviour
{
    public GameObject ball_1;

    public GameObject ball_2;

    public GameObject opp_1;
    public GameObject opp_2;

    //public BallMovement ballMovement;

    public int ball_counter = 0;

    public bool ball_multiplied = false;



    private void Start()
    {
        // set the opponents and the balls to false

        opp_1.SetActive(false);
        opp_2.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if ball_count is greater than ball_limiter --> spawn
        // begin launch/reset function
        //StartCoroutine(ballMovement.Launch());
        if (ball_counter == 0 && collision.gameObject.name == "Left Border")
        {
            //ball_1.SetActive(true);
            Instantiate(ball_1);
            ball_counter++;
        }

        else if (ball_counter == 1 && collision.gameObject.name == "Left Border")
        {
            Destroy(ball_1);
            Instantiate(ball_2);
        }

        //if (ball_counter == 0 && collision.gameObject.name == "Right Border")
        //{
        //    ball_1.SetActive(true);
        //    ball_multiplied = true;
        //    ball_counter++;
        //}

        //else if (ball_counter == 1 && collision.gameObject.name == "Right Border")
        //{
        //    ball_2.SetActive(true);
        //    ball_counter++;
        //}

    }
}
