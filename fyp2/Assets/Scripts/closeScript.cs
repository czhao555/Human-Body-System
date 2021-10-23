using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class closeScript : MonoBehaviour
{

    public void closeVideo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
        Screen.orientation = ScreenOrientation.Portrait;

    }
}
