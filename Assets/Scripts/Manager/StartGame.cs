using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        Refresh();
    }

    public static void Refresh()
    {
        BallReady.clear = true;
        PlayerReady.clear = true;
        OpponentReady.clear = true;
        Bounce.ScoreLeft = 0;
        Bounce.ScoreRight = 0;
    }

}
