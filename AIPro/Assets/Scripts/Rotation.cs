using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
  
        // Right Rotate
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 60);
        }

        // Left Rotate
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -60);
        }

    }
}
