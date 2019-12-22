using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsPlayer : MonoBehaviour
{
    public Transform cameraTarget;
    public float sSpeed = 0.1f;
    public Vector3 dist;
    public Transform lookTarget;


    int a;
    int b;
    Vector3 dPos;
Vector3 sPos;
    //GameObject targetObj;
    //Vector3 targetPos;



    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        b = 1;
        //targetObj = GameObject.Find("TargetGameObject");
        //targetPos = targetObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        dPos = cameraTarget.position + dist;
        sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        transform.position = sPos;

        transform.LookAt(lookTarget.position);

        //Vector3 c = lookTarget.transform.position - cameraTarget.transform.position;

        //// AIちゃん向きの取得。
        //Quaternion rotation = Quaternion.LookRotation(c);

        //// AIちゃん元の向きと変化された向きから補間してクルクル回る。
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 0.1f);
    }
}
