using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public List<GameObject> colliding = new List<GameObject>();
    public Vector2 up;
    void Start()
    {
        countDown.TimesUp += bounceObject;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        colliding.Add(collision.gameObject);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       colliding.Remove(collision.gameObject);
    }
    void bounceObject(int timeNum)
    {
        if(timeNum ==0)
        {
            foreach (GameObject a in colliding)
            {
                a.GetComponent<Rigidbody2D>().AddForce(up);
            }
        }
    }
}
