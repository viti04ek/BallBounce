using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float BounceForce;

    private bool _gameStarted = false;

    
    void Update()
    {
        if (Input.anyKeyDown && !_gameStarted)
            StartBounce();
    }


    void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), 1f);
        Rigidbody2D.AddForce(randomDirection * BounceForce, ForceMode2D.Impulse);

        _gameStarted = true;
        GameManager.Instance.GameStart();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FallCheck"))
            GameManager.Instance.Restart();
        else if (collision.gameObject.CompareTag("Paddle"))
            GameManager.Instance.ScoreUp();
    }


    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Rigidbody2D.velocity.normalized * BounceForce;
    }
}
