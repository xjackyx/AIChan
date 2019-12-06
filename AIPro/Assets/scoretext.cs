using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoretext : MonoBehaviour
{
    public Text ScoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = item.getscore();
        ScoreText.text = string.Format("収集力：{0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
