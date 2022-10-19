using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_Script2 : MonoBehaviour
{
    public bool playerGoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!playerGoal)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerScored();

            }

            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().OpponentScored();
            }
        }
    }
}
