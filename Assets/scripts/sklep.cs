using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sklep : MonoBehaviour
{
    public GameObject SKlepUI;
    public static int HotDogs =100;
    public GameObject GHat;
    public GameObject GHatUI;
    public Image Fillbar;
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Z))
        {
            SKlepUI.SetActive(!SKlepUI.activeInHierarchy);
        }

     
    }
    public void MakeHotdog()
    {
        if (movement.Parowy > 0 && movement.Buly > 0)
        {
            movement.Buly--;
            movement.Parowy--;
            HotDogs++;
            Debug.Log("hotdog bought!!");

        }
        else {
            Debug.Log("not enought resources!!");
        }

    }

    public void BuyHat()
    {
        if (movement.Buly > 2)
        {
            GHat.SetActive(true);
            GHatUI.SetActive(false);
            Debug.Log("Gentelman Hat bought!!");
        }
        else
        {
            Debug.Log("not enought resources!!");
        }
    }
    public void RfillEnergy()
    {
        if (movement.Parowy > 0)
        {
            Fillbar.fillAmount = 1;
            movement.Parowy--;
            Debug.Log("Energy Refilled!!");
        }
        else
        {
            Debug.Log("not enought resources!!");
        }
    }
}
