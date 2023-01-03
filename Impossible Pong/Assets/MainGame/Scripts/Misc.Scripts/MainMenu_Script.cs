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

    [SerializeField] GameObject split_pong_ios;
    // Multiply
    [SerializeField] GameObject multiply_pong;
    // Size
    [SerializeField] GameObject size_pong;
    // Impossible
    [SerializeField] GameObject impossible_pong;

    // grab question object
    [SerializeField] GameObject Query;

    [SerializeField] GameObject query_opponent;

    // vars that grab the act script on the game mode

    public ActivationScript reg_p2_opp_act;
    public ActivationScript split_p2_opp_act;
    public ActivationScript split_p2_opp_act_ios;
    public ActivationScript_Mult multiply_p2_opp_act;
    public ActivationScript impossible_p2_opp_act;
    public ActivationScript size_p2_opp_act;

    // grabbing the two images
    public Image opp_image;
    public Image p2_image;

    // grabbing bools of the images
    public bool opp_image_bool = false;
    public bool p2_image_bool = false;

    // grabbing bool of the questions being asked [query]s
    public bool ios_answer = false;
    public bool mac_answer = false;

    // func() that sets a bool as true/false depending on what is clicked

    // grab the funny text
    [SerializeField] GameObject funnyText;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            funnyText.SetActive(true);
        }
    }

    public void Opp_and_p2_visibility_image()
    {
        // if opp is true, set opp image to half transparent
        if (opp_image_bool == true)
        {
            // Set the opp color
            var oppColor = opp_image.color;
            oppColor.a = .60f;
            opp_image.color = oppColor;
            // set the p2 color
            var p2Color = p2_image.color;
            p2Color.a = 1f;
            p2_image.color = p2Color;
        }

        // if p2 is true, set p2 image as half transparent
        if (p2_image_bool == true)
        {
            // set the p2 color
            var p2Color = p2_image.color;
            p2Color.a = .60f;
            p2_image.color = p2Color;
            // set the opp color
            var oppColor = opp_image.color;
            oppColor.a = 1f;
            opp_image.color = oppColor;
        }
    }

    // Regular Pong
    public void PongScene()
    {

        if (opp_image_bool == false && p2_image_bool == false)
        {
            query_opponent.SetActive(true);
        }

        else
        {
            query_opponent.SetActive(false);
            canvas.GetComponent<Canvas>().enabled = false;

            pong_regular.SetActive(true);
        }
    }

    // Split Pong
    public void SplitScene()
    {


        // maybe we need to grab two act scripts for this game mode???

        if (opp_image_bool == false && p2_image_bool == false)
        {
            query_opponent.SetActive(true);
        }

        else
        {
            query_opponent.SetActive(false);
            Query.SetActive(true);

            if (gameObject.CompareTag("Mac"))
            {
                canvas.GetComponent<Canvas>().enabled = false;

                split_pong.SetActive(true);
            }

            else if (gameObject.CompareTag("Ios"))
            {
                canvas.GetComponent<Canvas>().enabled = false;

                split_pong_ios.SetActive(true);
            }

        }
    }

    // Multiply Pong
    public void MultiplyScene()
    {
        if (opp_image_bool == false && p2_image_bool == false)
        {
            query_opponent.SetActive(true);
        }

        else
        {
            canvas.GetComponent<Canvas>().enabled = false;

            multiply_pong.SetActive(true);
            query_opponent.SetActive(false);

        }

    }

    // Size Pong
    public void SizeScene()
    {
        if (opp_image_bool == false && p2_image_bool == false)
        {
            query_opponent.SetActive(true);
        }

        else
        {
            canvas.GetComponent<Canvas>().enabled = false;

            size_pong.SetActive(true);

            query_opponent.SetActive(false);

        }
    }

    // Imposible Pong
    public void ImpossibleScene()
    {

        if (opp_image_bool == false && p2_image_bool == false)
        {
            query_opponent.SetActive(true);
        }

        else
        {
            canvas.GetComponent<Canvas>().enabled = false;

            impossible_pong.SetActive(true);

            query_opponent.SetActive(false);
        }

    }

    // enable/disaable the player or opponnet based on button click

    public void Player2Activate()
    {
        p2_image_bool = true;
        opp_image_bool = false;

        reg_p2_opp_act.player2_active = true;
        reg_p2_opp_act.opponent_active = false;

        split_p2_opp_act.player2_active = true;
        split_p2_opp_act.opponent_active = false;

        split_p2_opp_act_ios.player2_active = true;
        split_p2_opp_act_ios.opponent_active = false;

        multiply_p2_opp_act.player2_active = true;
        multiply_p2_opp_act.opponent_active = false;

        impossible_p2_opp_act.player2_active = true;
        impossible_p2_opp_act.opponent_active = false;

        size_p2_opp_act.player2_active = true;
        size_p2_opp_act.opponent_active = false;

    }

    public void OpponentActivate()
    {
        opp_image_bool = true;
        p2_image_bool = false;

        reg_p2_opp_act.opponent_active = true;
        reg_p2_opp_act.player2_active = false;

        split_p2_opp_act.opponent_active = true;
        split_p2_opp_act.player2_active = false;

        split_p2_opp_act_ios.opponent_active = true;
        split_p2_opp_act_ios.player2_active = false;

        size_p2_opp_act.player2_active = false;
        size_p2_opp_act.opponent_active = true;

        impossible_p2_opp_act.opponent_active = true;
        impossible_p2_opp_act.player2_active = false;

        multiply_p2_opp_act.opponent_active = true;
        multiply_p2_opp_act.player2_active = false;
    }
}
