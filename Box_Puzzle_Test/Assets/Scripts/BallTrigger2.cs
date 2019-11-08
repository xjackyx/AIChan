using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger2 : MonoBehaviour
{
    [SerializeField]
    GameObject Ball;

    bool isMoved = false;

    private void OnTriggerEnter(Collider other)
    {
        if(isMoved == false)
        {
            isMoved = true;
            Ball.transform.position += new Vector3(3, 0, 0);
        }
    }
}
