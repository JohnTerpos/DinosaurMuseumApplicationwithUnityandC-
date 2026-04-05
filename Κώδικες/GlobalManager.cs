using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalManager : MonoBehaviour
{

    public float Money;
    public string CardNumber;
    public string Name;
    public string Surname;
    public string ExpDate;
    public string CVV;

    
    public GameObject cartUI;
    public GameObject shopUI;
    public GameObject buyUI;
    public GameObject Content;
    public Sprite trex;
    public Sprite trik;
    public Sprite dein;
    public Sprite brach;
    public Sprite velo;
    public Sprite anky;
    public Sprite steg;
    public Sprite game;
    void Start()
    {
        PlayerPrefs.SetFloat("Money", Money);
        PlayerPrefs.SetString("CardNumber", CardNumber);
        PlayerPrefs.SetString("Name", Name);
        PlayerPrefs.SetString("Surname", Surname);
        PlayerPrefs.SetString("ExpDate", ExpDate);
        PlayerPrefs.SetString("CVV", CVV);
        PlayerPrefs.SetInt("ItemsOnCart", 0);
        PlayerPrefs.SetInt("TrexOnCart", 0);
        PlayerPrefs.SetInt("DeinOnCart", 0);
        PlayerPrefs.SetInt("TrikOnCart", 0);
        PlayerPrefs.SetInt("BrachOnCart", 0);
        PlayerPrefs.SetInt("VeloOnCart", 0);
        PlayerPrefs.SetInt("AnkyOnCart", 0);
        PlayerPrefs.SetInt("StegOnCart", 0);
        PlayerPrefs.SetInt("GameOnCart", 0);
    }

    void Update()
    {
        GameObject.Find("Total_money").GetComponent<TextMeshProUGUI>().text= PlayerPrefs.GetFloat("Money").ToString();
    }


    public void show_cart()
    {
        Time.timeScale = 0f;
        cartUI.SetActive(true);
        shopUI.SetActive(false);
        GameObject.Find("items").GetComponent<TextMeshProUGUI>().text = "";
        GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text = "";
        if (PlayerPrefs.GetInt("TrexOnCart")>=1)
        {
            var obj = new GameObject();
            obj.AddComponent<RectTransform>();
            obj.AddComponent<Image>();
            obj.GetComponent<Image>().sprite = trex;
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 500);
            obj.transform.SetParent(Content.transform,false);
            obj.name = "trex_on_cart";
            GameObject.Find("items").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("TrexOnCart").ToString() + " x туяамосауяос\n";
            GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("TrexOnCart")*35).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("TrikOnCart") >= 1)
        {
            var obj = new GameObject();
            obj.AddComponent<RectTransform>();
            obj.AddComponent<Image>();
            obj.GetComponent<Image>().sprite = trik;
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 500);
            obj.transform.SetParent(Content.transform, false);
            obj.name = "trik_on_cart";
            GameObject.Find("items").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("TrikOnCart").ToString() + " x тяийеяатоь\n";
            GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("TrikOnCart") * 30).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("DeinOnCart") >= 1)
        {
            var obj = new GameObject();
            obj.AddComponent<RectTransform>();
            obj.AddComponent<Image>();
            obj.GetComponent<Image>().sprite = dein;
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 500);
            obj.transform.SetParent(Content.transform, false);
            obj.name = "dein_on_cart";
            GameObject.Find("items").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("DeinOnCart").ToString() + " x деимомувас\n";
            GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("DeinOnCart") * 30).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("BrachOnCart") >= 1)
        {
            var obj = new GameObject();
            obj.AddComponent<RectTransform>();
            obj.AddComponent<Image>();
            obj.GetComponent<Image>().sprite = brach;
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 500);
            obj.transform.SetParent(Content.transform, false);
            obj.name = "brach_on_cart";
            GameObject.Find("items").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("BrachOnCart").ToString() + " x бяавиосауяос\n";
            GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("BrachOnCart") * 35).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("StegOnCart") >= 1)
        {
            var obj = new GameObject();
            obj.AddComponent<RectTransform>();
            obj.AddComponent<Image>();
            obj.GetComponent<Image>().sprite = steg;
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 500);
            obj.transform.SetParent(Content.transform, false);
            obj.name = "steg_on_cart";
            GameObject.Find("items").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("StegOnCart").ToString() + " x стецосауяос\n";
            GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("StegOnCart") * 30).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("AnkyOnCart") >= 1)
        {
            var obj = new GameObject();
            obj.AddComponent<RectTransform>();
            obj.AddComponent<Image>();
            obj.GetComponent<Image>().sprite = anky;
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 500);
            obj.transform.SetParent(Content.transform, false);
            obj.name = "anky_on_cart";
            GameObject.Find("items").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("AnkyOnCart").ToString() + " x ацйукосауяос\n";
            GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("AnkyOnCart") * 30).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("GameOnCart") >= 1)
        {
            var obj = new GameObject();
            obj.AddComponent<RectTransform>();
            obj.AddComponent<Image>();
            obj.GetComponent<Image>().sprite = game;
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 500);
            obj.transform.SetParent(Content.transform, false);
            obj.name = "game_on_cart";
            GameObject.Find("items").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("GameOnCart").ToString() + " x бимтеопаивмиди\n";
            GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("GameOnCart") * 20).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("VeloOnCart") >= 1)
        {
            var obj = new GameObject();
            obj.AddComponent<RectTransform>();
            obj.AddComponent<Image>();
            obj.GetComponent<Image>().sprite = velo;
            obj.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 500);
            obj.transform.SetParent(Content.transform, false);
            obj.name = "velo_on_cart";
            GameObject.Find("items").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("VeloOnCart").ToString() + " x бекосияаптояас\n";
            GameObject.Find("prices").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("VeloOnCart") * 30).ToString() + "─\n";
        }
        GameObject.Find("total").GetComponent<TextMeshProUGUI>().text = "сЩМОКО: "+(PlayerPrefs.GetInt("VeloOnCart") * 30+ PlayerPrefs.GetInt("DeinOnCart") * 30+ PlayerPrefs.GetInt("StegOnCart") * 30+ PlayerPrefs.GetInt("AnkyOnCart") * 30+ PlayerPrefs.GetInt("BrachOnCart") * 35+ PlayerPrefs.GetInt("TrikOnCart") * 30+ PlayerPrefs.GetInt("TrexOnCart") * 35+PlayerPrefs.GetInt("GameOnCart") * 20).ToString() + "─\n";

    }

    public void back_to_shop()
    {
        if (GameObject.Find("trex_on_cart") != null)
        {
            Destroy(GameObject.Find("trex_on_cart"));
        }
        if (GameObject.Find("velo_on_cart") != null)
        {
            Destroy(GameObject.Find("velo_on_cart"));
        }
        if (GameObject.Find("game_on_cart") != null)
        {
            Destroy(GameObject.Find("game_on_cart"));
        }
        if (GameObject.Find("dein_on_cart") != null)
        {
            Destroy(GameObject.Find("dein_on_cart"));
        }
        if (GameObject.Find("steg_on_cart") != null)
        {
            Destroy(GameObject.Find("steg_on_cart"));
        }
        if (GameObject.Find("anky_on_cart") != null)
        {
            Destroy(GameObject.Find("anky_on_cart"));
        }
        if (GameObject.Find("brach_on_cart") != null)
        {
            Destroy(GameObject.Find("brach_on_cart"));
        }
        if (GameObject.Find("trik_on_cart") != null)
        {
            Destroy(GameObject.Find("trik_on_cart"));
        }
        cartUI.SetActive(false);
        shopUI.SetActive(true);
    }

    public void delete_cart()
    {
        if (GameObject.Find("trex_on_cart") != null)
        {
            Destroy(GameObject.Find("trex_on_cart"));
        }
        if (GameObject.Find("velo_on_cart") != null)
        {
            Destroy(GameObject.Find("velo_on_cart"));
        }
        if (GameObject.Find("game_on_cart") != null)
        {
            Destroy(GameObject.Find("game_on_cart"));
        }
        if (GameObject.Find("dein_on_cart") != null)
        {
            Destroy(GameObject.Find("dein_on_cart"));
        }
        if (GameObject.Find("steg_on_cart") != null)
        {
            Destroy(GameObject.Find("steg_on_cart"));
        }
        if (GameObject.Find("anky_on_cart") != null)
        {
            Destroy(GameObject.Find("anky_on_cart"));
        }
        if (GameObject.Find("brach_on_cart") != null)
        {
            Destroy(GameObject.Find("brach_on_cart"));
        }
        if (GameObject.Find("trik_on_cart") != null)
        {
            Destroy(GameObject.Find("trik_on_cart"));
        }
        PlayerPrefs.SetInt("ItemsOnCart", 0);
        PlayerPrefs.SetInt("TrexOnCart", 0);
        PlayerPrefs.SetInt("DeinOnCart", 0);
        PlayerPrefs.SetInt("TrikOnCart", 0);
        PlayerPrefs.SetInt("BrachOnCart", 0);
        PlayerPrefs.SetInt("VeloOnCart", 0);
        PlayerPrefs.SetInt("AnkyOnCart", 0);
        PlayerPrefs.SetInt("StegOnCart", 0);
        PlayerPrefs.SetInt("GameOnCart", 0);
        cartUI.SetActive(false);
        shopUI.SetActive(true);
    }

    public void continue_to_buy()
    {
        cartUI.SetActive(false);
        buyUI.SetActive(true);
        GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text = "";
        GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text = "";
        if (PlayerPrefs.GetInt("TrexOnCart") >= 1)
        {
            GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("TrexOnCart").ToString() + " x туяамосауяос\n";
            GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("TrexOnCart") * 35).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("TrikOnCart") >= 1)
        {
            GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("TrikOnCart").ToString() + " x тяийеяатоь\n";
            GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("TrikOnCart") * 30).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("DeinOnCart") >= 1)
        {
            GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("DeinOnCart").ToString() + " x деимомувас\n";
            GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("DeinOnCart") * 30).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("BrachOnCart") >= 1)
        {
            GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("BrachOnCart").ToString() + " x бяавиосауяос\n";
            GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("BrachOnCart") * 35).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("StegOnCart") >= 1)
        {
            GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("StegOnCart").ToString() + " x стецосауяос\n";
            GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("StegOnCart") * 30).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("AnkyOnCart") >= 1)
        {
            GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("AnkyOnCart").ToString() + " x ацйукосауяос\n";
            GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("AnkyOnCart") * 30).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("GameOnCart") >= 1)
        {
            GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("GameOnCart").ToString() + " x бимтеопаивмиди\n";
            GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("GameOnCart") * 20).ToString() + "─\n";
        }
        if (PlayerPrefs.GetInt("VeloOnCart") >= 1)
        {
            GameObject.Find("items_buy").GetComponent<TextMeshProUGUI>().text += PlayerPrefs.GetInt("VeloOnCart").ToString() + " x бекосияаптояас\n";
            GameObject.Find("prices_buy").GetComponent<TextMeshProUGUI>().text += (PlayerPrefs.GetInt("VeloOnCart") * 30).ToString() + "─\n";
        }
        GameObject.Find("total_buy").GetComponent<TextMeshProUGUI>().text = "сЩМОКО: " + (PlayerPrefs.GetInt("VeloOnCart") * 30 + PlayerPrefs.GetInt("DeinOnCart") * 30 + PlayerPrefs.GetInt("StegOnCart") * 30 + PlayerPrefs.GetInt("AnkyOnCart") * 30 + PlayerPrefs.GetInt("BrachOnCart") * 35 + PlayerPrefs.GetInt("TrikOnCart") * 30 + PlayerPrefs.GetInt("TrexOnCart") * 35 + PlayerPrefs.GetInt("GameOnCart") * 20).ToString() + "─\n";
    }

    public void back_to_cart()
    {
        cartUI.SetActive(true);
        buyUI.SetActive(false);
    }

}