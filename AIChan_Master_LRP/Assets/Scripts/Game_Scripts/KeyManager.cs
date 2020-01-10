using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Keyオブジェクトの管理
/// </summary>
public class KeyManager : MonoBehaviour
{
    public static int count = 0;
    static int oldcount = count;
    // Start is called before the first frame update
    void Start()
    {
        //シーン内にあるKeyの数を取得(Tagで取得)
        count = GameObject.FindGameObjectsWithTag("Key").Length;
        oldcount = count;
    }

    // Update is called once per frame
    void Update()
    {
        //Keyが取得されたとき(Keyの数が減った時)
        if (oldcount != count) 
        {
            //シーン内にあるKeyの数を取得(Tagで取得)
            count = GameObject.FindGameObjectsWithTag("Key").Length;
            //oldcountの更新
            oldcount = count;

            //シーン内にあるKeyの数が0になった時
            if(count==0)
            {
                //直接"Result"呼び出し
                //(Sceneの切り替えはゲームマネージャーのほうがいいかもしれない)
                //GameObject.Find("FadeManager").GetComponent<Fade>().TransitionScene("Result");
                Descent.DescentStart();
            }
        }
        else
        {

        }
    }

    //Key数変更の通知
    public static void KeyCountChange()
    {
        //countを-1
        count--;
    }
}
