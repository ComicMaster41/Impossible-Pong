using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Size_Paddle_Script : MonoBehaviour
{
    public Transform player_1;
    public Transform player_2;
    public Transform opponent;

    private float smallest_paddle_size = 2.980232e-08f;

    void Start()
    {
        player_1 = GameObject.Find("Player 1").GetComponent<Transform>();
        player_2 = GameObject.Find("Player_2_Size").GetComponent<Transform>();

        opponent = GameObject.Find("Opponent").GetComponent<Transform>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Right Border")
        {
            StartCoroutine(Increase_Paddle_Player2());
            StartCoroutine(Increase_Paddle_Opponent());
            StartCoroutine(Decrease_Paddle_Player1());

        }

        else if (collision.gameObject.tag == "Left Border")
        {
            StartCoroutine(Increase_Paddle_Player1());
            StartCoroutine(Decrease_Paddle_Player2());
            StartCoroutine(Decrease_Paddle_Opponent());
        }
    }

    public IEnumerator Increase_Paddle_Player1(){
        // OLS grabs the origional scale of the object
        Vector3 originalLocalScale = player_1.transform.localScale;
        // scale of object is added with a new vector 3
        player_1.transform.localScale += new Vector3(-0.2F, -0.2f, 0);
        yield return new WaitForSeconds(0);
    }

    public IEnumerator Increase_Paddle_Player2(){
        // OLS grabs the origional scale of the object
        Vector3 originalLocalScale = player_2.transform.localScale;
        // scale of object is added with a new vector 3
        player_2.transform.localScale += new Vector3(-0.2F, -0.2f, 0);
        yield return new WaitForSeconds(0);

    }

    public IEnumerator Increase_Paddle_Opponent()
    {
        // OLS grabs the origional scale of the object
        Vector3 originalLocalScale = opponent.transform.localScale;
        // scale of object is added with a new vector 3
        opponent.transform.localScale += new Vector3(-0.2F, -0.2f, 0);
        yield return new WaitForSeconds(0);

    }

    public IEnumerator Decrease_Paddle_Player1(){
        // OLS grabs the origional scale of the object
        Vector3 originalLocalScale = player_1.transform.localScale;
        // scale of object is added with a new vector 3
        player_1.transform.localScale += new Vector3(0.2F, 0.2f, 0);
        yield return new WaitForSeconds(0);

        if (player_1.transform.localScale == new Vector3(smallest_paddle_size, smallest_paddle_size, 1)){
            SceneManager.LoadScene(2);
        }
    }

    public IEnumerator Decrease_Paddle_Player2(){
        player_2.transform.localScale += new Vector3(0.2F, 0.2f, 0);
        yield return new WaitForSeconds(0);
        if (player_2.transform.localScale == new Vector3(smallest_paddle_size, smallest_paddle_size, 1))
        {
            SceneManager.LoadScene(2);
        }
    }

    public IEnumerator Decrease_Paddle_Opponent()
    {
        opponent.transform.localScale += new Vector3(0.2F, 0.2f, 0);
        yield return new WaitForSeconds(0);
        if (opponent.transform.localScale == new Vector3(smallest_paddle_size, smallest_paddle_size, 1))
        {
            SceneManager.LoadScene(2);
        }
    }
}
