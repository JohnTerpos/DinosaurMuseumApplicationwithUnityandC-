using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public GameObject ExitUI;

    public void to_ExitPanel()
    {
        
        ExitUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Exit()
    {
        Application.Quit();
    }


    public void Cancel()
    {
        Time.timeScale = 1f;
        ExitUI.SetActive(false);
    }
}
