using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationScript_Mult : MonoBehaviour
{

    // player 2
    [SerializeField] GameObject player2;
    // opponent
    [SerializeField] GameObject opponent;

    [SerializeField] GameObject p2_ball;
    [SerializeField] GameObject opp_ball;
    // depending on what is activated, the ball will activate

    public bool player2_active = false;
    public bool opponent_active = false;

    private void Start()
    {
        player2.SetActive(false);
        opponent.SetActive(false);

        p2_ball.SetActive(false);
        opp_ball.SetActive(false);
    }

    private void Update()
    {
        if (player2_active == true)
        {
            player2.SetActive(true);
            opponent.SetActive(false);

            p2_ball.SetActive(true);
            opp_ball.SetActive(false);
        }

        else if (opponent_active == true)
        {
            opponent.SetActive(true);
            player2.SetActive(false);

            p2_ball.SetActive(false);
            opp_ball.SetActive(true);
        }
    }
}
