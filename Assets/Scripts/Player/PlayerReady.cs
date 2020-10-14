using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReady : MonoBehaviour
{
    static Vector2 startPosition;
    public static bool clear = false;
    Rigidbody2D rb;

    void Start()
    {
        startPosition = new Vector2(-3f, 0);
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Refresh(transform, rb);
    }

    public static void Refresh(Transform t, Rigidbody2D rb)
    {
        if (clear)
        {
            t.position = startPosition;
            rb.velocity = new Vector2(0, 0);
            clear = false;
        }
    }
}
