using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    GameObject player;
    const float OFFSET_POS_Y = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        // ここに毬栗ゲーで作った感じにカメラのやつやってけばいいと思う。
        this.player = GameObject.Find("Player");

        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y + OFFSET_POS_Y, playerPos.z - 13.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            // カメラの移動
            transform.Translate(0, 0.1f, 0);

        }

        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y + OFFSET_POS_Y, playerPos.z - 13.0f);

    }
}
