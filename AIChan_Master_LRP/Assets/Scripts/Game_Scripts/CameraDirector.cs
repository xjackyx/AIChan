using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirector : MonoBehaviour
{
    [SerializeField]
    public GameObject TopDownCamera;
    //[SerializeField]
    //public GameObject thirdPersonCamera;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // スペースキーでカメラを切り替える
        if (Input.GetKeyDown(KeyCode.B) || Input.GetButtonDown("ModeChange"))
        {
            // ↓現在のactive状態から反転 
            TopDownCamera.SetActive(!TopDownCamera.activeInHierarchy);
            //thirdPersonCamera.SetActive(!thirdPersonCamera.activeInHierarchy);

            //BOの機能オンオフ
            if (BOList.humanmode == true)
            {
                //オフ
                BOList.humanmode = false;
            }
            else if (BOList.humanmode == false)
            {
                //オン
                BOList.humanmode = true;
            }
        }
    }
}