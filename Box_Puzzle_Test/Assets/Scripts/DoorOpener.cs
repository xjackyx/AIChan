using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {

    #region Attributes

    public Transform ball;



    public Vector3 BallStayPosition = new Vector3(0.0f, 0.0f, 3.0f);
    public Vector3 BallMovePosition = new Vector3(3.0f, 0.0f, 3.0f);



    public float moveSpeed = 1;


    private bool move = false;

    #endregion

    #region MonoBehaviour API

    private void FixedUpdate()
    {

        if (move)
        {
            ball.position = Vector3.Lerp(ball.position,
                BallMovePosition, Time.deltaTime * moveSpeed);
        }
        else
        {
            ball.position = Vector3.Lerp(ball.position,
                BallStayPosition, Time.deltaTime * moveSpeed);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bar")
            {
                BallMove();
            }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bar")
        {
            BallStay();
        }
    }

    #endregion


    public void BallStay()
    {
        move = false;
    }

    public void BallMove()
    {
        move = true;
    }
}
