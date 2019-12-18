using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Rotation : MonoBehaviour
{
    //private bool RotationActive = false;


    // Update is called once per frame
    void Update()
    {

        //BOの機能オンの時のみ
        if (BOList.humanmode == true)
        {
            RotateRight();
            RotateLeft();
        }

    }

    public void RotateRight()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("RotateRight"))
        {
            transform.Rotate(Vector3.up, 60);
        }
    }

    public void RotateLeft()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("RotateLeft"))
        {
            transform.Rotate(Vector3.up, -60);
        }
    }

}
