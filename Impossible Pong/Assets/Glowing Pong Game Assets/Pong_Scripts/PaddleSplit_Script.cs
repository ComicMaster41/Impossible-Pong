using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSplit_Script : MonoBehaviour
{
    public GameObject split_paddle1;
    public GameObject split_paddle2;
    public GameObject split_paddle3;

    public GameObject split_opponent_paddle1;
    public GameObject split_opponent_paddle2;
    public GameObject split_opponent_paddle3;
    //public override void Apply(GameObject target)
    //{
    //    void 

    //    if (target.gameObject.CompareTag("Player 1"))
    //    {

    //        //Instantiate()
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // State w/out paddle split
        if (collision.gameObject.CompareTag("Player 1"))
        {
            Destroy(collision.gameObject);
            Instantiate(split_paddle1);
        }

        else if (collision.gameObject.CompareTag("Player 2"))
        {
            Destroy(collision.gameObject);
            Instantiate(split_opponent_paddle1);
        }

        // Primary State

        if (collision.gameObject.CompareTag("Player 1_1"))
        {
            Debug.Log("This works Player");
            Destroy(collision.gameObject);
            Instantiate(split_paddle2);
        }

        else if (collision.gameObject.CompareTag("Player 2_1"))
        {
            Debug.Log("This works Opponent");
            Destroy(collision.gameObject);
            Instantiate(split_opponent_paddle2);
        }

        // Secondary State

        //if (collision.gameObject.CompareTag("Player 1_2"))
        //{
        //    Destroy(collision.gameObject);
        //    Instantiate(split_paddle3);
        //}

        //else if (collision.gameObject.CompareTag("Player 2_2"))
        //{
        //    Destroy(collision.gameObject);
        //    Instantiate(split_opponent_paddle3);
        //}
    }
}
