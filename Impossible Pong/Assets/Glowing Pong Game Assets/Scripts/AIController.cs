using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform ball;

    [Range(0,1)]
    public float skill;
    private void FixedUpdate()
    {
        Vector2 newPos = transform.position;
        newPos.y = Mathf.Lerp(transform.position.y, ball.position.y, skill);
        transform.position = newPos;
    }
}
