using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentReady : MonoBehaviour
{
    static Vector2 startPosition;
    public static bool clear = false;

    void Start()
    {
        startPosition = new Vector2(3, 0);
    }

    private void Update()
    {
        Refresh(transform);
    }

    public static void Refresh(Transform t)
    {
        if (clear)
        {
            t.position = startPosition;
            clear = false;
        }
    }
}
