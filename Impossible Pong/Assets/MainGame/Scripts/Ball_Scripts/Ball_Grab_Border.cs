using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Grab_Border : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Right Border" || collision.gameObject.name == "Left Border")
        {
            Destroy(gameObject);
        }
    }
}
