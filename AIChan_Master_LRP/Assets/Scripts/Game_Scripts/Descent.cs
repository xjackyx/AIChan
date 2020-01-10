using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// BO降下のスクリプト
/// </summary>
public class Descent : MonoBehaviour
{
    //降下するか判断するBool
    public static bool start = false;
    //降下スピード
    float speed;
    //降下スピード調整用
    public float DescentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //降下スタート時
        if (start == true) 
        {
            speed += -0.01f;
            this.transform.position = new Vector3(this.transform.position.x, speed * DescentSpeed, this.transform.position.z);

            //降下の制限
            if (this.transform.position.y <= -1.5f) 
            {
                start = false;
            }
        }
    }

    public static void DescentStart()
    {
        start = true;
    }
}
