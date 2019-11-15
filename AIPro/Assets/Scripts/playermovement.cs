using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float speed = 10;

    private Rigidbody rb;

    private Vector3 Player_pos; //プレイヤーのポジション


    #region Monobehaviour API

    void Start()
    {
        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);


        Vector3 diff = transform.position - Player_pos; //プレイヤーがどの方向に進んでいるかがわかるように、初期位置と現在地の座標差分を取得

        if (diff.magnitude > 0.01f) //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
        {
            transform.rotation = Quaternion.LookRotation(diff);  //ベクトルの情報をQuaternion.LookRotationに引き渡し回転量を取得しプレイヤーを回転させる
        }

        Player_pos = transform.position; //プレイヤーの位置を更新

    }

    #endregion
}
