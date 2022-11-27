using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Script : MonoBehaviour
{
    public GameObject ball;
    public GameObject paddle;
    public GameObject p2;
    public GameObject opponent;

    public void ResetEntirePosition()
    {
        ball.GetComponent<Ball_Script>().Reset();
        paddle.GetComponent<Paddle_Script>().Reset();
        opponent.GetComponent<Paddle_Script>().Reset();
    }
}
