using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeMenuPanel : MonoBehaviour
{
   
    public GameObject panel;
    // Start is called before the first frame update
    public void closePanel()
    {
        panel.gameObject.SetActive(false);

    }

}
