using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float Speed;

    
    void FixedUpdate()
    {
        TouchMove();
    }


    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0)
            {
                Rigidbody2D.velocity = Vector2.left * Speed;
            }
            else
            {
                Rigidbody2D.velocity = Vector2.right * Speed;
            }
        }
        else
        {
            Rigidbody2D.velocity = Vector2.zero;
        }
    }
}
