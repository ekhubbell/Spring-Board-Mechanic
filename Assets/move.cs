using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    float x;

    void Update()
    {
        x = 0.0f;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            x = -speed;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            x = speed;
         }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
}
