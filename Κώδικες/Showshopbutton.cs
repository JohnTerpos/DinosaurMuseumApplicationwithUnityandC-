using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showshopbutton : MonoBehaviour
{
    public GameObject ui_object;
    public GameObject ShopUI;
    public static bool ShopPressed = false;

    void Start()
    {
        ui_object.SetActive(false);
        ShopUI.SetActive(false);
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
                if (ShopPressed)
                {
                    Time.timeScale = 1f;
                    ShopUI.SetActive(false);
                    ShopPressed = false;
                }
                else
                {
                    Time.timeScale = 0f;
                    ShopUI.SetActive(true);
                    ShopPressed = true;
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
        ShopPressed = false;
        ShopUI.SetActive(false);
    }

}
