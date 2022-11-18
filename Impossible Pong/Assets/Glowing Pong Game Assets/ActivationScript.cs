using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationScript : MonoBehaviour
{

    // player 2
    [SerializeField] GameObject player2;
    // opponent
    [SerializeField] GameObject opponent;

    public bool player2_active = false;
    public bool opponent_active = false;

    private void Start()
    {
        player2.SetActive(false);
        opponent.SetActive(false);

    }

    private void Update()
    {
        if (player2_active == true)
        {
            player2.SetActive(true);
            opponent.SetActive(false);
        }

        else if (opponent_active == true)
        {
            opponent.SetActive(true);
            player2.SetActive(false);
        }
    }
}
