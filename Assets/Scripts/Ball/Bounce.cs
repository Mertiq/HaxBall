using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bounce : MonoBehaviour
{
    Rigidbody2D rb;

    public static int ScoreRight = 0;
    public static int ScoreLeft = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("BorderTop"))
        {
            rb.velocity = new Vector3(rb.velocity.x, -0.5f, 0);
        }
        else if (collision.transform.CompareTag("BorderBottom"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 0.5f, 0);
        }
        else if (collision.transform.CompareTag("BorderRight"))
        {
            rb.velocity = new Vector3(-0.5f, rb.velocity.y, 0);
        }
        else if (collision.transform.CompareTag("BorderLeft"))
        {
            rb.velocity = new Vector3(0.5f, rb.velocity.y, 0);
        }

        if (collision.transform.CompareTag("KaleLeft"))
        {
            ScoreRight++;
            BallReady.clear = true;
            PlayerReady.clear = true;
            OpponentReady.clear = true;
        }
        else if (collision.transform.CompareTag("KaleRight"))
        {
            ScoreLeft++;
            BallReady.clear = true;
            PlayerReady.clear = true;
            OpponentReady.clear = true;
        }

    }
}
