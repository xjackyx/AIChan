using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectbutton : MonoBehaviour
{
    Button button1;
    Button button2;
    Button button3;

    // Start is called before the first frame update
    void Start()
    {
        button1 = GameObject.Find("Start").GetComponent<Button>();
        button2 = GameObject.Find("Option").GetComponent<Button>();
        button3 = GameObject.Find("Garry").GetComponent<Button>();
        //ボタンが選択された状態になる
        button1.Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
