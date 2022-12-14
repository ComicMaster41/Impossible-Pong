using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Spawn_Script : MonoBehaviour
{

    public GameObject ball_prefab;

    public GameObject ball_1;

    public GameObject ball_2;

    public BallMovement ballMovement;

    private int ball_count = 0;

    public int ball_limiter = 3;

    public int ball_spawned = 0;



    private void Start()
    {
        // check how many balls are in the game --> shoot a message in console
        ball_count++;

        ball_1.SetActive(false);
        ball_2.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Right Border" && ball_spawned == 1 || collision.gameObject.name == "Left Border" && ball_spawned == 1)
        {

        // if ball_count is greater than ball_limiter --> spawn
            InvokeRepeating("SpawnMultipleBalls", 1.0f, 1.0f);
            ballMovement.player1Start = false;
            // begin launch/reset function
            StartCoroutine(ballMovement.Launch());
        }
        // ISSUE: after the entire thing runs through, it can still spawn more
    }

    void SpawnMultipleBalls()
    {

        if (ball_count <= ball_limiter)
        {
            ball_spawned++;
            Instantiate(ball_prefab);
            ball_count++;
            //displays to the console how many balls are in the game --> keeps getting bigger
        }
        else
        {
            CancelInvoke("SpawnMultipleBalls");
        }
    }
}
