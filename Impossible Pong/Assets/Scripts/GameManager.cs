using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player")]
    public GameObject playerPaddle;
    public GameObject leftWall;

    [Header("Opponent")]
    public GameObject opponentPaddle;
    public GameObject rightWall;

    [Header("Score UI")]
    public GameObject playerText;
    public GameObject opponentText;

    private int playerScore;
    private int opponentScore;

    public void PlayerScored()
    {
        playerScore++;
        playerText.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
        ResetPosition();
    }

    public void OpponentScored()
    {
        opponentScore++;
        opponentText.GetComponent<TextMeshProUGUI>().text = opponentScore.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball_Script>().Reset();
        playerPaddle.GetComponent<Paddle_Script>().Reset();
        opponentPaddle.GetComponent<Paddle_Script>().Reset();
    }
}
