using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenVideo : MonoBehaviour
{

    public void OpenV()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
}
