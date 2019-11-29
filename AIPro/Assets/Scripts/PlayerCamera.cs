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

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y + OFFSET_POS_Y, playerPos.z - 13.0f);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(0, 250, 0);
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }
}
