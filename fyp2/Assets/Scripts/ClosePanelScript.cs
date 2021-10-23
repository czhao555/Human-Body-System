using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClosePanelScript : MonoBehaviour
{
    public Button tutorial;
    public Button backToMain;
    public Button openSliderButton;
    public GameObject panel;
    // Start is called before the first frame update
    public void closePanel()
    {
        panel.gameObject.SetActive(false);
        openSliderButton.gameObject.SetActive(true);
        backToMain.gameObject.SetActive(true);
        tutorial.gameObject.SetActive(true);
    }
    
}
