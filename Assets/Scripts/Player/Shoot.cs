using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ball;
    bool canShoot = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            FindTheWayToGo.FindWay(ball.transform, transform);
            ball.GetComponent<Rigidbody2D>().velocity = new Vector3(FindTheWayToGo.wayY * 5f, FindTheWayToGo.wayX * 5f, 0);    
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ball")
        {
            canShoot = true;    
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ball")
        {
            canShoot = false;
        }
    }


}
