using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIcon : MonoBehaviour
{
    public GameObject _parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _parent = transform.root.gameObject;
        Vector3 pos = _parent.transform.position;
        transform.position = pos;
    }
}
