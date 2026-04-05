using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class add_to_cart : MonoBehaviour
{

    public GameObject review_cart_trex;
    public GameObject review_cart_trik;
    public GameObject review_cart_dein;
    public GameObject review_cart_velo;
    public GameObject review_cart_brach;
    public GameObject review_cart_anky;
    public GameObject review_cart_steg;
    public GameObject review_cart_game;
    public GameObject cart_icon;

    void Update()
    {
        if (PlayerPrefs.GetInt("ItemsOnCart")>0)
        {
            cart_icon.SetActive(true);
            GameObject.Find("Cart_text").GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("ItemsOnCart").ToString();
        }
        else
        {
            cart_icon.SetActive(false);
            review_cart_trex.SetActive(false);
            review_cart_trik.SetActive(false);
            review_cart_dein.SetActive(false);
            review_cart_steg.SetActive(false);
            review_cart_brach.SetActive(false);
            review_cart_anky.SetActive(false);
            review_cart_velo.SetActive(false);
            review_cart_game.SetActive(false);
        }
    }

    public void add_trex()
    {
        PlayerPrefs.SetInt("ItemsOnCart", PlayerPrefs.GetInt("ItemsOnCart") + 1);
        PlayerPrefs.SetInt("TrexOnCart", PlayerPrefs.GetInt("TrexOnCart") + 1);
        review_cart_trex.SetActive(true);
    }

    public void add_trik()
    {
        PlayerPrefs.SetInt("ItemsOnCart", PlayerPrefs.GetInt("ItemsOnCart") + 1);
        PlayerPrefs.SetInt("TrikOnCart", PlayerPrefs.GetInt("TrikOnCart") + 1);
        review_cart_trik.SetActive(true);
    }

    public void add_dein()
    {
        PlayerPrefs.SetInt("ItemsOnCart", PlayerPrefs.GetInt("ItemsOnCart") + 1);
        PlayerPrefs.SetInt("DeinOnCart", PlayerPrefs.GetInt("DeinOnCart") + 1);
        review_cart_dein.SetActive(true);
    }

    public void add_velo()
    {
        PlayerPrefs.SetInt("ItemsOnCart", PlayerPrefs.GetInt("ItemsOnCart") + 1);
        PlayerPrefs.SetInt("VeloOnCart", PlayerPrefs.GetInt("VeloOnCart") + 1);
        review_cart_velo.SetActive(true);
    }

    public void add_brach()
    {
        PlayerPrefs.SetInt("ItemsOnCart", PlayerPrefs.GetInt("ItemsOnCart") + 1);
        PlayerPrefs.SetInt("BrachOnCart", PlayerPrefs.GetInt("BrachOnCart") + 1);
        review_cart_brach.SetActive(true);
    }

    public void add_steg()
    {
        PlayerPrefs.SetInt("ItemsOnCart", PlayerPrefs.GetInt("ItemsOnCart") + 1);
        PlayerPrefs.SetInt("StegOnCart", PlayerPrefs.GetInt("StegOnCart") + 1);
        review_cart_steg.SetActive(true);
    }

    public void add_anky()
    {
        PlayerPrefs.SetInt("ItemsOnCart", PlayerPrefs.GetInt("ItemsOnCart") + 1);
        PlayerPrefs.SetInt("AnkyOnCart", PlayerPrefs.GetInt("AnkyOnCart") + 1);
        review_cart_anky.SetActive(true);
    }

    public void add_game()
    {
        PlayerPrefs.SetInt("ItemsOnCart", PlayerPrefs.GetInt("ItemsOnCart") + 1);
        PlayerPrefs.SetInt("GameOnCart", PlayerPrefs.GetInt("GameOnCart") + 1);
        review_cart_game.SetActive(true);
    }
}
