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
        slider.maxValue = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score += 1;
            slider.value += score;
            Destroy(gameObject);
        }
    }

    public static int getscore()
    {
        return score;
    }

}
