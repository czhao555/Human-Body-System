using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tutorialScript : MonoBehaviour
{
    public GameObject Panel;
    public Button tutorial;
    public Button openSliderButton;
    public Button backtoMain;
    // Start is called before the first frame update
    public void openTutorial()
    {
        backtoMain.gameObject.SetActive(false);
        openSliderButton.gameObject.SetActive(false);
        tutorial.gameObject.SetActive(false);
        Panel.gameObject.SetActive(true);
    }
}
