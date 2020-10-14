using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentShoot : MonoBehaviour
{
    public GameObject ball;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball")
        {
            FindTheWayToGo.FindWay(ball.transform, transform);
            ball.GetComponent<Rigidbody2D>().velocity = new Vector3(FindTheWayToGo.wayY * 5f, FindTheWayToGo.wayX * 5f, 0);
        }
    }
}
