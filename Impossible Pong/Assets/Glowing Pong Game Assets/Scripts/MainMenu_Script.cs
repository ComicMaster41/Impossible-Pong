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

    public ActivationScript p2_opp_act;

    //public bool player2_active = false;
    //public bool opponent_active = false;


    // Regular Pong
    public void PongScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        pong_regular.SetActive(true);

        //p2_opp_act.P2_Opponent_Activation();

        //activationScript.P2_Opponent_Activation();

    }

    // Split Pong
    public void SplitScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        split_pong.SetActive(true);

        //activationScript.P2_Opponent_Activation();

    }

    // Multiply Pong
    public void MultiplyScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        multiply_pong.SetActive(true);

        //activationScript.P2_Opponent_Activation();

    }

    // Size Pong
    public void SizeScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        size_pong.SetActive(true);

        //activationScript.P2_Opponent_Activation();

    }

    // Imposible Pong
    public void ImpossibleScene()
    {
        canvas.GetComponent<Canvas>().enabled = false;

        impossible_pong.SetActive(true);

        //activationScript.P2_Opponent_Activation();

    }


    // enable/disaable the player or opponnet

    public void Player2Activate()
    {
        p2_opp_act.player2_active = true;
        //Debug.Log("player 2 true and opponent false");
        p2_opp_act.opponent_active = false;

    }

    public void OpponentActivate()
    {
        p2_opp_act.opponent_active = true;
        //Debug.Log("opponent true and player 2 false");
        p2_opp_act.player2_active = false;

    }
}
