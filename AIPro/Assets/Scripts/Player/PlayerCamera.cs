using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    GameObject player;
    const float OFFSET_POS_Y = 4.0f;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    // ここに毬栗ゲーで作った感じにカメラのやつやってけばいいと思う。
    //    this.player = GameObject.Find("Player");

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    Vector3 playerPos = this.player.transform.position;
    //    transform.position = new Vector3(playerPos.x, playerPos.y + OFFSET_POS_Y, playerPos.z - 13.0f);

    //    //Vector3 relativePos = player.transform.position - this.transform.position;

    //    transform.RotateAround(player.transform.position, Vector3.up, 180);

    //    //transform.LookAt(player.transform.localEulerAngles);
    //}






    public Transform cameraTarget;
    public float sSpeed = 10.0f;
    public Vector3 dist;
    public Transform lookTarget;



    private void FixedUpdate()
    {
        Vector3 dPos = cameraTarget.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed + Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }




    /*
    一旦消しとく
GameObject targetObj;
Vector3 targetPos;

void Start()
{
    targetObj = GameObject.Find("Player");
}

void Update()
{

    transform.LookAt(targetObj.transform);

}
*/



}
