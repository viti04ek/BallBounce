using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float BounceForce;

    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            StartBounce();
        }
    }


    void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), 1f);

        Rigidbody2D.AddForce(randomDirection * BounceForce, ForceMode2D.Impulse);
    }
}
