using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class BOList : MonoBehaviour
{
    public GameObject[] BO;
    public int count = 0;

    // Update is called once per frame
    void Update()
    {
        //BO[0].GetComponent<Rotation>().enabled = false;
        //BO[1].GetComponent<Rotation>().enabled = false;
        //BO[2].GetComponent<Rotation>().enabled = false;
        //BO[3].GetComponent<Rotation>().enabled = false;
        //BO[4].GetComponent<Rotation>().enabled = false;
        //BO[5].GetComponent<Rotation>().enabled = false;
        //BO[6].GetComponent<Rotation>().enabled = false;
        //BO[7].GetComponent<Rotation>().enabled = false;
        //BO[8].GetComponent<Rotation>().enabled = false;
        //BO[9].GetComponent<Rotation>().enabled = false;
        //BO[10].GetComponent<Rotation>().enabled = false;
        //BO[11].GetComponent<Rotation>().enabled = false;
        //BO[12].GetComponent<Rotation>().enabled = false;

        BO[0].GetComponent<Rotation>().enabled = true;

        if (count >= 1)
        {
            BO[0].GetComponent<Rotation>().enabled = false;
        }
 

        if (Input.GetKeyDown(KeyCode.L))
        {
            count++;
            if (count >= 13)
            {
                count = count - 1;
            }
            switch (count)
            {
                case 0:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count-1].GetComponent<Rotation>().enabled = false;
                    break;
                case 1:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 2:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 3:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 4:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 5:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 6:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 7:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 8:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 9:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 10:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 11:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 12:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 13:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count - 1].GetComponent<Rotation>().enabled = false;
                    
                    break;

                default:
                    break;

            }
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            count--;
            if(count < 0)
            {
                count = count + 1;
            }
            switch (count)
            {
                case 0:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 1:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 2:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 3:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 4:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 5:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 6:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 7:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 8:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 9:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 10:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 11:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 12:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;
                case 13:
                    BO[count].GetComponent<Rotation>().enabled = true;
                    BO[count + 1].GetComponent<Rotation>().enabled = false;
                    break;

                default:
                    break;
            }
        }


        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    count++;
        //    BO[count].GetComponent<Rotation>().enabled = true;
        //    if(count>=13)
        //    {
        //        count = 0;
        //    }
        //}
        //else
        //{
        //    BO[count-1].GetComponent<Rotation>().enabled = false;

        //}




    }
}
