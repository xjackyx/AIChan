using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamera : MonoBehaviour
{
    GameObject player;
    const float OFFSET_POS_Y = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        // ここに毬栗ゲーで作った感じにカメラのやつやってけばいいと思う。
        this.player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPos = this.player.transform.position;
        //transform.position = new Vector3(playerPos.x, playerPos.y + OFFSET_POS_Y, playerPos.z);
        //transform.position = new Vector3(playerPos.x, playerPos.y, 0);
        //transform.position = new Vector3(0, 0, 0);

    }
}
