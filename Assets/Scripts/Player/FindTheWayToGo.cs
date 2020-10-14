using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class FindTheWayToGo : MonoBehaviour
{
    public static int wayX;
    public static int wayY;

    public static float startPointX;
    public static float startPointY;


    public static void FindWay(Transform ball, Transform player)
    {
        startPointX = ball.position.x;
        startPointY = ball.position.y;
        if(player.position.x >= ball.position.x && player.position.y >= ball.position.y)
        {
            wayX = -1;
            wayY = -1;
        }
        else if (player.position.x < ball.position.x && player.position.y > ball.position.y)
        {
            wayX = -1;
            wayY = 1;
        }
        else if (player.position.x <= ball.position.x && player.position.y <= ball.position.y)
        {
            wayX = 1;
            wayY = 1;
        }
        else if (player.position.x > ball.position.x && player.position.y < ball.position.y)
        {
            wayX = 1;
            wayY = -1;
        }
    }

}
