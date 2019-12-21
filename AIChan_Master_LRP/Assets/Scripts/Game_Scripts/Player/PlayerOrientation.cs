using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrientation : MonoBehaviour
{
    public float moveSpeed; //プレイヤーの動くスピード
    float inputHorizontal;
    float inputVertical;

    public Transform cameraTarget;


    private Vector3 Player_pos; //プレイヤーのポジション
    private float x; //x方向のImputの値
    private float z; //z方向のInputの値
    private Rigidbody rigd;

    void Start()
    {
        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
        rigd = GetComponent<Rigidbody>(); //プレイヤーのRigidbodyを取得
    }

    void Update()
    {

        x = Input.GetAxis("Horizontal"); //x方向のInputの値を取得
        z = Input.GetAxis("Vertical"); //z方向のInputの値を取得


        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rigd.velocity = moveForward * moveSpeed + new Vector3(x * 0.00001f, rigd.velocity.y, z * 0.00001f);

        //// キャラクターの向きを進行方向に
        //if (moveForward != Vector3.zero)
        //{
        //    transform.rotation = Quaternion.LookRotation(moveForward);
        //}

        //rigd.velocity = new Vector3(x * speed, 0, z * speed); //プレイヤーのRigidbodyに対してInputにspeedを掛けた値で更新し移動


        // ■ここまでのプレイヤーの動きを変えれば、押した方向に動けるはずｗ



        Vector3 diff = transform.position - Player_pos; //プレイヤーがどの方向に進んでいるかがわかるように、初期位置と現在地の座標差分を取得

        if (diff.magnitude > 0.00001f) //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
        {
            // AIちゃん向きの取得。
            Quaternion rotation = Quaternion.LookRotation(diff);

            // AIちゃん元の向きと変化された向きから補間してクルクル回る。
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 0.1f);
        }

        //Player_pos = transform.position; //プレイヤーの位置を更新
    }
}