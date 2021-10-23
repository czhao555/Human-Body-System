using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTransparency : MonoBehaviour
{
    public GameObject LungsParent;
    public GameObject alveoli;

    public void SetT(float sliderValue)
    {
        
        switch (sliderValue)
        {
            case 0:
                {
                    for (int i = 0; i < 14; ++i)
                    {
                        LungsParent.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    break;
                    alveoli.SetActive(false);
                    // toggle0.interactable = false;
                }
            case 1:
                {
                    
                    for (int i = 0; i < 14; ++i)
                    {
                        if (i ==0 )
                        {
                            LungsParent.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        else
                            LungsParent.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    break;
                    alveoli.SetActive(false);
                }
            case 2:
                {
                    for (int i = 0; i < 14; ++i)
                    {
                        
                        if ((i>=1 && i <= 5) || i == 0)
                        {
                            LungsParent.transform.GetChild(i).gameObject.SetActive(false);
                        }
                        else
                        {
                            LungsParent.transform.GetChild(i).gameObject.SetActive(true);
                        }
                    }
                    alveoli.SetActive(false);
                    break;
                }
            case 3:
                {
                    for (int i = 0; i < 14; ++i)
                    {

                        if (i >= 1 && i <= 9 || i == 0)
                        {
                            LungsParent.transform.GetChild(i).gameObject.SetActive(false);
                        }
                        else
                        {
                            LungsParent.transform.GetChild(i).gameObject.SetActive(true);
                        }
                    }
                    alveoli.SetActive(false);
                    break;
                }
            case 4:
                {
                    for (int i = 0; i < 14; ++i)
                    {
                        LungsParent.transform.GetChild(i).gameObject.SetActive(false);
                        
                    }
                    alveoli.SetActive(true);
                    break;
                }
            default:
                break;
        }
        
    }

    

}
