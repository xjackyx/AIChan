using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrientation : MonoBehaviour
{
    public float speed; //プレイヤーの動くスピード

    private Vector3 Player_pos; //プレイヤーのポジション
    private float x; //x方向のImputの値
    private float z; //z方向のInputの値
    private Rigidbody rigd;

    float step;
    public Transform Moveback;


    void Start()
    {
        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
        rigd = GetComponent<Rigidbody>(); //プレイヤーのRigidbodyを取得
    }

    void Update()
    {

        x = Input.GetAxis("Horizontal"); //x方向のInputの値を取得
        z = Input.GetAxis("Vertical"); //z方向のInputの値を取得

        //Vector3 playerMovement = new Vector3(x, 0, z); //プレイヤーのRigidbodyに対してInputにspeedを掛けた値で更新し移動

        //transform.Translate(playerMovement, Space.Self);

        //rigd.velocity = new Vector3(x * speed * 0.5f, 0, z * speed * 0.5f); //プレイヤーのRigidbodyに対してInputにspeedを掛けた値で更新し移動

        Vector3 diff = transform.position - Player_pos; //プレイヤーがどの方向に進んでいるかがわかるように、初期位置と現在地の座標差分を取得

        //if (diff.magnitude > 0.01f) //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
        //                            //if (diff.magnitude > 0.0001f) //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
        //{
        //    transform.rotation = Quaternion.LookRotation(diff);  //ベクトルの情報をQuaternion.LookRotationに引き渡し回転量を取得しプレイヤーを回転させる
        //}


        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(new Vector3(0f, x, 0f));
            transform.eulerAngles += new Vector3(0f, x, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0f, x, 0f);
        }

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Rotate(new Vector3(0f, -x, 0f));

        //}

        // 移動処理
        rigd.velocity += transform.forward * z;

/*
        // Quaternion.Slerpと併用して、指定したオブジェクトの方向になめらかに回転する。
        Vector3 MovebackPosition = Moveback.position;
        if (transform.position.y != Moveback.position.y)
        {
            MovebackPosition = new Vector3(Moveback.position.x, transform.position.y, Moveback.position.z);
        }
        Quaternion targetRotation = Quaternion.LookRotation(MovebackPosition - transform.position);
        transform.rotation = Quaternion.Slerp(Moveback.transform.rotation, Quaternion.Euler(0, 90f, 0), 0.01f);

        //指定した方向にゆっくり回転させる。
        //step = speed * Time.deltaTime;
        //    transform.rotation = Quaternion.Slerp(Moveback.transform.rotation, Quaternion.Euler(0, 90f, 0), 0.01f);
*/


        //Player_pos = transform.position; //プレイヤーの位置を更新
    }


    //float inputHorizontal;
    //float inputVertical;
    //Rigidbody rb;

    //float moveSpeed = 3f;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //void Update()
    //{
    //    inputHorizontal = Input.GetAxisRaw("Horizontal");
    //    inputVertical = Input.GetAxisRaw("Vertical");
    //}

    //void FixedUpdate()
    //{
    //    // カメラの方向から、X-Z平面の単位ベクトルを取得
    //    Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

    //    // 方向キーの入力値とカメラの向きから、移動方向を決定
    //    Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

    //    // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
    //    rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

    //    // キャラクターの向きを進行方向に
    //    if (moveForward != Vector3.zero)
    //    {
    //        transform.rotation = Quaternion.LookRotation(moveForward);
    //    }
    //}


}