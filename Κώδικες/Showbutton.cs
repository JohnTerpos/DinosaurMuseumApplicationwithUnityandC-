using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showbutton : MonoBehaviour
{
    public GameObject ui_object;

    public Animator anim1;
    public Animator anim2;

    void Start()
    {
        ui_object.SetActive(false);
    }

    void Update()
    {
        if (anim2.GetCurrentAnimatorStateInfo(0).IsName("button"))
        {
            anim2.SetBool("bp", false);
        }
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
                anim2.SetBool("bp", true);
                ui_object.SetActive(false);
                StartCoroutine(waiter());
                
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
    
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(3);
        anim1.Play("walk");
    }
}
