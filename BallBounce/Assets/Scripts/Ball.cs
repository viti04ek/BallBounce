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
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);

        Rigidbody2D.AddForce(randomDirection * BounceForce, ForceMode2D.Impulse);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FallCheck"))
            GameManager.Instance.Restart();
        else if (collision.gameObject.CompareTag("Paddle"))
            GameManager.Instance.ScoreUp();
    }
}
