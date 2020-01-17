using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public float Floating;
    public bool x;
    public bool y;
    public bool z;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Sakihama
        //演出項目----------------------------

        //回転
        if (x == true)
            transform.Rotate(Vector3.right, 1);
        if (y == true)
            transform.Rotate(Vector3.up, 1);
        if (z == true)
            transform.Rotate(Vector3.forward, 1);

        //上下移動
        float sin = Mathf.Sin(Time.time);
        //固定用(省略用)
        float Tx = this.transform.position.x;
        float Ty = this.transform.position.y;
        float Tz = this.transform.position.z;
        this.transform.position = new Vector3(Tx, (sin * Floating * 0.001f) + Ty, Tz);

        //-------------------------------------
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //Key1個消化
            KeyManager.KeyCountChange();
        }
    }

}
