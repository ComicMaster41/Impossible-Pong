using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_Script : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    // Pong
    [SerializeField] GameObject pong_regular;
    // Split
    [SerializeField] GameObject split_pong;
    // Multiply
    [SerializeField] GameObject multiply_pong;
    // Size
    [SerializeField] GameObject size_pong;
    // Impossible
    [SerializeField] GameObject impossible_pong;

    // grabbing the player 2 and opponent gameobjects

    // player 2
    [SerializeField] GameObject player2;
    // opponent
    [SerializeField] GameObject opponent;

    // Regular Pong
    public void PongScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        pong_regular.SetActive(true);
    }

    // Split Pong
    public void SplitScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        split_pong.SetActive(true);
    }

    // Multiply Pong
    public void MultiplyScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        multiply_pong.SetActive(true);
    }

    // Size Pong
    public void SizeScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        size_pong.SetActive(true);
    }

    // Imposible Pong
    public void ImpossibleScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        impossible_pong.SetActive(true);
    }


    // enable/disaable the player or opponnet

    public void Player2Enable()
    {
        player2.SetActive(true);
    }

    public void Player2Disable()
    {
        player2.SetActive(false);
    }

    public void OpponentEnable()
    {
        opponent.SetActive(false);
    }

    public void OpponentDisable()
    {
        opponent.SetActive(false);
    }
}
