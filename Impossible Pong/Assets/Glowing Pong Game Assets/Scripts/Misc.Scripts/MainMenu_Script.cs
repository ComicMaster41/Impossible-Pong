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

    // vars that grab the act script on the game mode

    public ActivationScript reg_p2_opp_act;
    public ActivationScript split_p2_opp_act;
    public ActivationScript multiply_p2_opp_act;
    public ActivationScript impossible_p2_opp_act;
    public ActivationScript size_p2_opp_act;



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

    // enable/disaable the player or opponnet based on button click

    public void Player2Activate()
    {
        reg_p2_opp_act.player2_active = true;
        reg_p2_opp_act.opponent_active = false;

        split_p2_opp_act.player2_active = true;
        split_p2_opp_act.opponent_active = false;

        multiply_p2_opp_act.player2_active = true;
        multiply_p2_opp_act.opponent_active = false;

        impossible_p2_opp_act.player2_active = true;
        impossible_p2_opp_act.opponent_active = false;

        size_p2_opp_act.player2_active = true;
        size_p2_opp_act.opponent_active = false;

    }

    public void OpponentActivate()
    {
        reg_p2_opp_act.opponent_active = true;
        reg_p2_opp_act.player2_active = false;

        split_p2_opp_act.opponent_active = true;
        split_p2_opp_act.player2_active = false;

        size_p2_opp_act.player2_active = false;
        size_p2_opp_act.opponent_active = true;

        impossible_p2_opp_act.opponent_active = true;
        impossible_p2_opp_act.player2_active = false;

        multiply_p2_opp_act.opponent_active = true;
        multiply_p2_opp_act.player2_active = false;
    }
}
