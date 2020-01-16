using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public float Floating;
    private GameObject eventsystem;
    private ItemContoroller script;

    // Start is called before the first frame update
    void Start()
    {
        eventsystem = GameObject.Find("ItemUI");

        script = eventsystem.GetComponent<ItemContoroller>();
    }

    // Update is called once per frame
    void Update()
    {
        //Sakihama
        //演出項目----------------------------

        //回転
        transform.Rotate(Vector3.up, 1);
        //上下移動
        float sin = Mathf.Sin(Time.time);
        //固定用(省略用)
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float z = this.transform.position.z;
        this.transform.position = new Vector3(x, (sin * Floating * 0.001f) + y, z);

        //-------------------------------------
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //アイテム数カウント
            script.count += 1;
            //Key1個消化
            KeyManager.KeyCountChange();
        }
    }

}
