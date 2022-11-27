using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationScript_Split : MonoBehaviour
{

    // player 2
    [SerializeField] GameObject player2;
    // opponent
    [SerializeField] GameObject opponent;

    public GameObject ball1;
    public GameObject ball2;

    public bool player2_active = false;
    public bool opponent_active = false;

    private void Start()
    {
        player2.SetActive(false);
        opponent.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);

    }

    private void Update()
    {
        if (player2_active == true)
        {
            ball1.SetActive(true);
            player2.SetActive(true);
            opponent.SetActive(false);
        }

        else if (opponent_active == true)
        {
            ball2.SetActive(true);
            opponent.SetActive(true);
            player2.SetActive(false);
        }
    }
}
