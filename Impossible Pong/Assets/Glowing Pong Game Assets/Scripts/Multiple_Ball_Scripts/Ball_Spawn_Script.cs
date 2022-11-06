using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Spawn_Script : MonoBehaviour
{

    public GameObject ball_prefab;
    public BallMovement ballMovement;

    public int ball_count = 0;


    private void OnCollisionEnter2D(Collision2D collision) {


        if (collision.gameObject.name == "Right Border" || collision.gameObject.name == "Left Border")
        {
            if (ball_count <= 2){
                InvokeRepeating("SpawnMultipleBalls", 4, 4);
            }
            else{
                CancelInvoke("SpawnMultipleBalls");
            }

            ballMovement.player1Start = false;
            // begin launch/reset function
            StartCoroutine(ballMovement.Launch());
        }
    }

    void SpawnMultipleBalls(){
        Instantiate(ball_prefab);
        ball_count++;
    }
}
