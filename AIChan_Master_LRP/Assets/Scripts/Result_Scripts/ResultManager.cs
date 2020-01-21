using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)|| Input.GetButtonDown("GameStart"))
        {
            // SampleSceneをロードする
            GameObject.Find("FadeManager").GetComponent<Fade>().TransitionScene("Title");
        }
    }
}
