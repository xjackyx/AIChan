using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsPlayer : MonoBehaviour
{
    public Transform cameraTarget;
    public Transform TopDownCameraTarget;

    private bool bFlag;
    public bool BFlag
    {
        get
        {
            return bFlag;
        }
        set
        {
            bFlag = value;
        }
    }


    public float sSpeed = 0.1f;
    public Vector3 dist;
    public Transform lookTarget;
    public Transform lookCentralTarget;

    private GameObject ceiling;
    private PlayerIconController script;
    private GameObject AIChan;
    private GameObject ChildAIChan;

    Vector3 dPos;
    Vector3 sPos;


    // Start is called before the first frame update
    void Start()
    {
        bFlag = false;
        AIChan = GameObject.Find("aiイメージ");
        ChildAIChan = AIChan.transform.Find("PlayerIcon").gameObject;
        script = ChildAIChan.GetComponent<PlayerIconController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bFlag == false)
        {
            dPos = cameraTarget.position + dist;
            sPos = Vector3.Slerp(transform.position, dPos, sSpeed * Time.deltaTime);
            transform.position = sPos;
            transform.LookAt(lookTarget.position);
        }


        if (bFlag)
        {
            dPos = TopDownCameraTarget.position + dist;
            sPos = Vector3.Slerp(transform.position, dPos, sSpeed * Time.deltaTime);
            transform.position = sPos;
            //transform.LookAt(lookTarget.position);

            // 4つ目のカメラバージョン
            transform.LookAt(lookCentralTarget.position);
        }

        // が押されたら上から視点のカメラ2つに切り替わる。そこまで補間。
        if (Input.GetKeyDown(KeyCode.C))
        {
            bFlag = !bFlag;
            script.ActiveControl(bFlag);
        }
    }
}
