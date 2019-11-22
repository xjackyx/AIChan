using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Rotation : MonoBehaviour
{
    //private bool RotationActive = false;


    // Update is called once per frame
    void Update()
    {


        RotateRight();
        RotateLeft();


        //if(BO[1] == true)
        //{
        //    GetComponent<Rotation>().enabled = true;


        //    // Right Rotate
        //    RotateRight();

        //    // Left Rotate
        //    RotateLeft();
        //}
        //else
        //{
        //    GetComponent<Rotation>().enabled = false;
        //}

    }

    public void RotateRight()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, 60);
        }
    }

    public void RotateLeft()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(Vector3.up, -60);
        }
    }

}
