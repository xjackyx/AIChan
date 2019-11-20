using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject firstPersonCamera;
    [SerializeField]
    private GameObject thirdPersonCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーでカメラを切り替える
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ↓現在のactive状態から反転 
            firstPersonCamera.SetActive(!firstPersonCamera.activeInHierarchy);
            thirdPersonCamera.SetActive(!thirdPersonCamera.activeInHierarchy);
        }
    }
}