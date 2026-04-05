using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDinoInfo : MonoBehaviour
{
    public GameObject ui_object;
    public GameObject DinoUI;
    public static bool DinoPressed = false;

    void Start()
    {
        ui_object.SetActive(false);
        DinoUI.SetActive(false);
    }


    public void OnTriggerEnter(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            ui_object.SetActive(true);
        }
    }

    public void OnTriggerStay(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            if (Input.GetKey("e"))
            {

                ui_object.SetActive(false);
                if (DinoPressed)
                {
                    Time.timeScale = 1f;
                    DinoUI.SetActive(false);
                    DinoPressed = false;
                }
                else
                {
                    Time.timeScale = 0f;
                    DinoUI.SetActive(true);
                    DinoPressed = true;
                }

            }
        }
    }

    public void OnTriggerExit(Collider obj)
    {
        if (obj.CompareTag("Player"))
        {
            ui_object.SetActive(false);
        }
    }

    public void Exit()
    {
        Time.timeScale = 1f;
        DinoPressed = false;
        DinoUI.SetActive(false);
    }

}
