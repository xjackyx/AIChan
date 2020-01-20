using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIconController : MonoBehaviour
{
    int a;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveControl(bool index)
    {
        if (index == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
