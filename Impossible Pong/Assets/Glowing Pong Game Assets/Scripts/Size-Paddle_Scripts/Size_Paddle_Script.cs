using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size_Paddle_Script : MonoBehaviour
{
    public Transform player_1;
    public Transform player_2;

    void Start()
    {
        player_1 = GameObject.Find("Player 1").GetComponent<Transform>();
        player_2 = GameObject.Find("Player 2").GetComponent<Transform>();        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Right Border")
        {
            StartCoroutine(Increase_Paddle_Opponent());
            Debug.Log("Opponent shrunk");
            StartCoroutine(Decrease_Paddle_Player());

        }

        else if (collision.gameObject.name == "Left Border")
        {
            StartCoroutine(Increase_Paddle_Player());
            Debug.Log("Player shrunk");
            StartCoroutine(Decrease_Paddle_Opponent());

        }
    }

    public IEnumerator Increase_Paddle_Player(){
        // OLS grabs the origional scale of the object
        Vector3 originalLocalScale = player_1.transform.localScale;
        // scale of object is added with a new vector 3
        player_1.transform.localScale += new Vector3(-0.2F, -0.2f, 0);
        yield return new WaitForSeconds(0);
    }

    public IEnumerator Increase_Paddle_Opponent(){
        // OLS grabs the origional scale of the object
        Vector3 originalLocalScale = player_2.transform.localScale;
        // scale of object is added with a new vector 3
        player_2.transform.localScale += new Vector3(-0.2F, -0.2f, 0);
        yield return new WaitForSeconds(0);

    }

    public IEnumerator Decrease_Paddle_Player(){
        // OLS grabs the origional scale of the object
        Vector3 originalLocalScale = player_1.transform.localScale;
        // scale of object is added with a new vector 3
        player_1.transform.localScale += new Vector3(0.2F, 0.2f, 0);
        yield return new WaitForSeconds(0);
    }

    public IEnumerator Decrease_Paddle_Opponent(){
        player_2.transform.localScale += new Vector3(0.2F, 0.2f, 0);
        yield return new WaitForSeconds(0);

    }
}
