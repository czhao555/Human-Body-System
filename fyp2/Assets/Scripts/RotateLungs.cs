using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateLungs : MonoBehaviour
{
    private Touch touch;
    private Vector3 p;
    private Quaternion rotationX, rotationZ, rotationY;
    private float rotateSpeedModifier = 0.1f;

    public float ClickDuration = 2;
    //public UnityEvent OnLongClick;
    //float totalDownTime = 0;

    string LungPartName;

    public GameObject lunggg;
    void Update()
    {

        /*if (Input.GetMouseButtonDown(0))
        {
            totalDownTime += Time.deltaTime;
            Debug.Log(Time.deltaTime + "hahahahhahs");
            if (totalDownTime >= ClickDuration)
            {
                Debug.Log("iniininninin");
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit Hit;
                if (Physics.Raycast(ray, out Hit))
                {
                    LungPartName = Hit.transform.name;
                    switch (LungPartName)
                    {
                        case "rightPulmonaryVein":
                            Debug.Log("panel innn");
                            Panel.SetActive(true);
                            break;
                        case "rightPulmonaryArtery":
                            Panel.SetActive(true);
                            break;
                        case "leftPulmonaryVein":
                            Panel.SetActive(true);
                            break;
                        case "leftPulmonaryArtery":
                            Panel.SetActive(true);
                            break;
                        case "rightUpperLobe":
                            Panel.SetActive(true);
                            break;
                        case "rightMiddleLobe":
                            Panel.SetActive(true);
                            break;
                        case "rightInferiorLobe":
                            Panel.SetActive(true);
                            break;
                        case "leftUpperLobe":
                            Panel.SetActive(true);
                            break;
                        case "leftInferiorLobe":
                            Panel.SetActive(true);
                            break;
                        case "trachea":
                            Panel.SetActive(true);
                            break;
                        case "primaryBronchus":
                            Panel.SetActive(true);
                            break;
                        case "secandaryBronchus":
                            Panel.SetActive(true);
                            break;
                        case "tertiaryBronchus":
                            Panel.SetActive(true);
                            break;

                        default:
                            break;

                    }
                }
            }

        }*/

        if (Input.touchCount > 0 && Input.touchCount < 2)
        {
            touch = Input.GetTouch(0);

            if(!(EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)) && (touch.phase == TouchPhase.Moved))
            {
                rotationX = Quaternion.Euler(touch.deltaPosition.y * rotateSpeedModifier, 0f, 0f);
                rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotateSpeedModifier, 0f);
                transform.rotation = rotationX * transform.rotation;
                transform.rotation = rotationY * transform.rotation;
                Debug.Log(rotationX);
                Debug.Log(rotationY);
            }
     

        }
    }
}
