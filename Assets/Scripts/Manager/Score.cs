using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int ScoreOfRightSide;
    int ScoreOfLeftSide;

    public Text rightText;
    public Text leftText;

    void Update()
    {
        ScoreOfRightSide = Bounce.ScoreRight;
        ScoreOfLeftSide = Bounce.ScoreLeft;

        rightText.text = ScoreOfRightSide.ToString();
        leftText.text = ScoreOfLeftSide.ToString();

        if(ScoreOfLeftSide == 10 || ScoreOfRightSide == 10)
        {
            StartGame.Refresh();
        }

    }
}
