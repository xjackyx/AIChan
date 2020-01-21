using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class UIList : MonoBehaviour
{
    public GameObject[] UI;
    public int count = 0;

    // Update is called once per frame
    void Update()
    {
        //UI[0].gameObject.SetActive(true);
        //UI[1].gameObject.SetActive(true);
        //UI[2].gameObject.SetActive(true);
        //UI[3].gameObject.SetActive(true);
        //UI[4].gameObject.SetActive(true);
        //UI[5].gameObject.SetActive(true);
        //UI[6].gameObject.SetActive(true);
        //UI[7].gameObject.SetActive(true);
        //UI[8].gameObject.SetActive(true);
        //UI[9].gameObject.SetActive(true);
        //UI[10].gameObject.SetActive(true);
        //UI[11].gameObject.SetActive(true);
        //UI[12].gameObject.SetActive(true);
        //UI[13].gameObject.SetActive(true);

        UI[0].gameObject.SetActive(true);
 

        if (count >= 1)
        {
            UI[0].gameObject.SetActive(false);
        }
        //BOの機能オンの時のみ
        if (BOList.humanmode == true)
        {
            // 次に選択
            if (Input.GetKeyDown(KeyCode.L) || Input.GetButtonDown("RightSelect"))
            {
                count++;
                if (count >= 13)
                {
                    count = count - 1;
                }
                switch (count)
                {
                    case 0:
                        UI[count].gameObject.SetActive(false);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 1:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 2:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 3:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 4:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 5:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 6:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 7:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 8:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 9:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 10:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 11:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 12:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    case 13:
                        UI[count].gameObject.SetActive(true);
                        UI[count - 1].gameObject.SetActive(false);
                        break;
                    default:
                        break;

                }
            }

            //前に選択処理
            if (Input.GetKeyDown(KeyCode.J)|| Input.GetButtonDown("LeftSelect"))
            {
                count--;
                if (count < 0)
                {
                    count = count + 1;
                }
                switch (count)
                {
                    case 0:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 1:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 2:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 3:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 4:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 5:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 6:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 7:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 8:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 9:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 10:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 11:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 12:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;
                    case 13:
                        UI[count].gameObject.SetActive(true);
                        UI[count + 1].gameObject.SetActive(false);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
