using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSelectedPart : MonoBehaviour
{

    //public Slider sliders;
    public GameObject LungsParent;
    public SetTransparency setT;

    void Start()
    {
      
    }
    public void ShowSelectedPartOnly(bool toggleValue)
    {

        if (toggleValue == true)
        {
            for (int i = 0; i < 14; ++i)
            {
                if (i == ShowInfo.PassNumberofVideo)
                {
                    LungsParent.transform.GetChild(ShowInfo.PassNumberofVideo).gameObject.SetActive(true);
                }
                else
                    LungsParent.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        if (toggleValue == false)
        {
            //sliders.interactable = true;
            for (int j = 0; j < 14; j++)
            {
                Debug.Log("ShowInfo.PassNumberofVideokkk" + ShowInfo.PassNumberofVideo);
                if (ShowInfo.PassNumberofVideo == 0)
                {
                    setT.SetT(0f);
                }
                else if (ShowInfo.PassNumberofVideo >= 1 && ShowInfo.PassNumberofVideo <= 5)
                {
                    setT.SetT(1f);
                }
                else if (ShowInfo.PassNumberofVideo >= 6 && ShowInfo.PassNumberofVideo <= 9)
                {
                    setT.SetT(2f);
                }
                else if (ShowInfo.PassNumberofVideo >= 10 && ShowInfo.PassNumberofVideo <= 13)
                {
                    setT.SetT(3f);
                }
                

                //sliders.interactable = false;
            }


        }
    }
}
