using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help_menu : MonoBehaviour
{
    public static bool HelpPressed = false;
    public GameObject helpUi;

    void Start()
    {
        helpUi.SetActive(false);
    }


    public void Resume()
    {
        HelpPressed = false;
        helpUi.SetActive(false);
        
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        HelpPressed= true;
        helpUi.SetActive(true);
        StartCoroutine(waiter());
    }


    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0f;
    }
}
