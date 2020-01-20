using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGage : MonoBehaviour
{
    public GameObject[] UI;
    public static int count = 5;
    public int oldcount = count;
    public int getcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //初期化
        count = 5;
        oldcount = count;
        getcount = 0; 

        //強制的に無効化(念のため)
        for (int n = count - 1; n >= 0; n--) 
        {
            UI[n].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (oldcount != count) 
        {
            UI[getcount].gameObject.SetActive(true);
            getcount++;
            oldcount = count;
        }
    }

    public static void KeyCountChange()
    {
        //countを-1
        count--;
    }
}
