using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buy : MonoBehaviour
{

    public GameObject CardNumber;
    public GameObject ExpDate;
    public GameObject Name;
    public GameObject Surname;
    public GameObject CVV;

    public GameObject error_money;
    public GameObject error_card;
    public GameObject successUI;
    public GameObject buyUI;
    public void complete()
    {
        float total_money = (PlayerPrefs.GetInt("VeloOnCart") * 30 + PlayerPrefs.GetInt("DeinOnCart") * 30 + PlayerPrefs.GetInt("StegOnCart") * 30 + PlayerPrefs.GetInt("AnkyOnCart") * 30 + PlayerPrefs.GetInt("BrachOnCart") * 35 + PlayerPrefs.GetInt("TrikOnCart") * 30 + PlayerPrefs.GetInt("TrexOnCart") * 35 + PlayerPrefs.GetInt("GameOnCart") * 20);
        error_money.SetActive(false);
        error_card.SetActive(false);
        if (CardNumber.GetComponent<TMP_InputField>().text == PlayerPrefs.GetString("CardNumber") && ExpDate.GetComponent<TMP_InputField>().text == PlayerPrefs.GetString("ExpDate") && Name.GetComponent<TMP_InputField>().text == PlayerPrefs.GetString("Name") && Surname.GetComponent<TMP_InputField>().text == PlayerPrefs.GetString("Surname") && CVV.GetComponent<TMP_InputField>().text == PlayerPrefs.GetString("CVV"))
        {
            if (total_money<= PlayerPrefs.GetFloat("Money"))
            {
                PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money") - total_money);
                PlayerPrefs.SetInt("ItemsOnCart", 0);
                PlayerPrefs.SetInt("TrexOnCart", 0);
                PlayerPrefs.SetInt("DeinOnCart", 0);
                PlayerPrefs.SetInt("TrikOnCart", 0);
                PlayerPrefs.SetInt("BrachOnCart", 0);
                PlayerPrefs.SetInt("VeloOnCart", 0);
                PlayerPrefs.SetInt("AnkyOnCart", 0);
                PlayerPrefs.SetInt("StegOnCart", 0);
                PlayerPrefs.SetInt("GameOnCart", 0);
                buyUI.SetActive(false);
                successUI.SetActive(true);
            }
            else
            {
                error_money.SetActive(true);
            }
        }
        else
        {
            error_card.SetActive(true);
        }
    }

    public void back_to_museum()
    {
        Time.timeScale = 1f;
        successUI.SetActive(false);
    }
}
