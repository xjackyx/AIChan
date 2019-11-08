using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{

    public Transform ball;

    public Vector3 ballPosition = new Vector3(0, 0 ,3);
    public Vector3 movedBallPosition = new Vector3(0, 0, 6);

    public float moveSpeed = 5;

    private bool move = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            ball.position = Vector3.Lerp(ball.position, movedBallPosition, Time.deltaTime * moveSpeed);
        }else
        {
            ball.position = Vector3.Lerp(ball.position, ballPosition, Time.deltaTime * moveSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bar")
        {
            // true 
            movedBall();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bar")
        {
            // false
            Ball();
        }
    }


    public void Ball()
    {
        move = false;
    }

    public void movedBall()
    {
        move = true;
    }
}
