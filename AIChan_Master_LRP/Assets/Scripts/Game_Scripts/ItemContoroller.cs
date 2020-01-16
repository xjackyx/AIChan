using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemContoroller : MonoBehaviour
{
    public Transform Item;
    public int count = 0;

    void Start()
    {
        Item.GetChild(0).gameObject.SetActive(false); //Item1非表示
        Item.GetChild(1).gameObject.SetActive(false); //Item2非表示
        Item.GetChild(2).gameObject.SetActive(false); //Item3非表示
        Item.GetChild(3).gameObject.SetActive(false); //Item4非表示
        Item.GetChild(4).gameObject.SetActive(false); //Item5非表示
    }

    public void Update()
    {
        var num = count;
        for(int n = 0; n < num; n++)
        {
            Item.GetChild(n).gameObject.SetActive(true);
        }
    }
}
