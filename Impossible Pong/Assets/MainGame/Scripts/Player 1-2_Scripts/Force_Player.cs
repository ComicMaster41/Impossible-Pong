using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force_Player : MonoBehaviour
{
    public GameObject split_paddle_2;

    private SplitPaddle_Script splitpaddle_script;

    private void Update()
    {
        if (splitpaddle_script.active == true)
        {
            Vector3 direction = transform.position - split_paddle_2.transform.position;
            direction.Normalize();
        }
    }

    // whenever the paddle splits, it goes to the fingers direction

    // either make the paddle gravitate away from the player, or make it an ai

    // ai is easier

    // gravitate is funner

    // if gravity: grab the object, 
}
