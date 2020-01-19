using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrientation : MonoBehaviour
{
    public float moveSpeed; //プレイヤーの動くスピード

    [SerializeField]
    private float MAGNITUDE_CONTROL = 0.001f;

    float inputHorizontal;
    float inputVertical;

    public Transform cameraTarget;


    private Vector3 Player_pos; //プレイヤーのポジション
    public float PlayerOrientarion;
    private float x; //x方向のImputの値
    private float z; //z方向のInputの値
    private Rigidbody rigd;

    private GameObject MainCamera;
    private CameraFollowsPlayer CameraFollowsPlayerScr;

    void Start()
    {
        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
        rigd = GetComponent<Rigidbody>(); //プレイヤーのRigidbodyを取得
        PlayerOrientarion = 0.15f;

        MainCamera = GameObject.Find("MainCamera");
        CameraFollowsPlayerScr = MainCamera.GetComponent<CameraFollowsPlayer>();
    }

    void Update()
    {
            x = Input.GetAxis("Horizontal"); //x方向のInputの値を取得
            z = Input.GetAxis("Vertical"); //z方向のInputの値を取得

        // 上から視点フラグOFF時は動けなくする。
        if (CameraFollowsPlayerScr.BFlag == false)
        {
            // カメラの方向から、X-Z平面の単位ベクトルを取得
            Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

            // 方向キーの入力値とカメラの向きから、移動方向を決定
            Vector3 moveForward = cameraForward * z + Camera.main.transform.right * x;

            // 移動方向にスピードを掛ける。
            rigd.velocity = moveForward * moveSpeed;

            //プレイヤーがどの方向に進んでいるかがわかるように、初期位置と現在地の座標差分を取得
            Vector3 diff = transform.position - Player_pos;

            Player_pos = transform.position; //プレイヤーの位置を更新

            // キャラクターの向きを進行方向に
            //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
            if (diff.magnitude > MAGNITUDE_CONTROL)
            {
                // AIちゃん向きの取得。
                Quaternion rotation = Quaternion.LookRotation(diff);

                // AIちゃん元の向きと変化された向きから補間してクルクル回る。
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, PlayerOrientarion);

                //transform.rotation = Quaternion.LookRotation(moveForward);
            }
        }
    }
}