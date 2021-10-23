using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenuTutorial : MonoBehaviour
{
    public GameObject Panel;

    public void openMenuTutorial()
    {
        Panel.gameObject.SetActive(true);
    }
}
