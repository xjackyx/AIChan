using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Scene機能の利用に必要なusing文

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // SampleSceneをロードする
            GameObject.Find("FadeManager").GetComponent<Fade>().TransitionScene("Stage1");
        }
    }

    // SampleScene(バトル画面)へのシーン遷移を行うメソッド
    // ボタンUIの入力時に呼び出される
    public void TransitionScene()
    {
        // SampleSceneをロードする
        GameObject.Find("FadeManager").GetComponent<Fade>().TransitionScene("Stage1");
    }
}
