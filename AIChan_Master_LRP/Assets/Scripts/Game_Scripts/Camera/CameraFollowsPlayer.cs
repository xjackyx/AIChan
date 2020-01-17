using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsPlayer : MonoBehaviour
{
    public Transform cameraTarget;
    public Transform TopDownCameraTarget;
    bool bFlag;

    public float sSpeed = 0.1f;
    public Vector3 dist;
    public Transform lookTarget;
    public Transform lookCentralTarget;

    private GameObject ceiling;

    int a;
    int b;
    Vector3 dPos;
    Vector3 sPos;



    // Start is called before the first frame update
    void Start()
    {
        bFlag = false;
        a = 0;
        b = 1;
        ceiling = GameObject.Find("Ceiling");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(bFlag == false)
        {
            dPos = cameraTarget.position + dist;
            sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
            transform.position = sPos;

            transform.LookAt(lookTarget.position);
        }

        
        // が押されたら上から視点のカメラ2つに切り替わる。そこまで補間。
        if (Input.GetKeyDown(KeyCode.C))
        {
            bFlag = !bFlag;

            // 天井を消す。天井のスクリプトにアクセスして、消す関数を呼べばいいと思うｗ
            ceiling.GetComponent<Ceiling>().ChangeActive();

        }
        if (bFlag)
        {
            dPos = TopDownCameraTarget.position + dist;
            sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
            transform.position = sPos;
            transform.LookAt(lookCentralTarget.position);
        }
    }
}
