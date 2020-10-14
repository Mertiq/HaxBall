using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentMove : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject ball;
    Transform TBall;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        TBall = ball.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3;
        if (TBall.position.x < 0)
        {
            vector3 = new Vector3(-TBall.position.x, TBall.position.y, TBall.position.z);
        }
        else
        {
            vector3 = new Vector3(TBall.position.x, TBall.position.y, TBall.position.z);
        }

        transform.position = vector3;
    }
}
