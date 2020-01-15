using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInterpolation : MonoBehaviour
{
    //スタートと終わりの目印
    public Transform startMarker;
    public Transform endMarker;

    // スピード
    public float speed = 0.1F;

    //二点間の距離を入れる
    private float distance_two;

    bool bFlag;

    void Start()
    {
        //二点間の距離を代入(スピード調整に使う)
        distance_two = Vector3.Distance(startMarker.position, endMarker.position);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            bFlag = true;
        }
        if (bFlag)
        {
            // 現在の位置
            float present_Location = (Time.time * speed) / distance_two;

            // オブジェクトの移動
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
            //transform.position = Vector3.Lerp(startMarker.position, endMarker.position, 0.1f);
        }
    }
}
