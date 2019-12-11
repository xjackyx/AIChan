using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class item : MonoBehaviour
{
    public static int score;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.Find("slider").GetComponent<Slider>();
        slider.maxValue = 5;
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
        //固定用
        float x = this.transform.position.x;
        float z = this.transform.position.z;
        this.transform.position = new Vector3(x, (sin * 0.5f)+1.5f, z);

        //-------------------------------------
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score += 1;
            slider.value += score;
            Destroy(gameObject);
            //Key1個消化
            KeyManager.KeyCountChange();
        }
    }

    public static int getscore()
    {
        return score;
    }

}
