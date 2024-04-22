using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sklep : MonoBehaviour
{
    public GameObject SKlepUI;
    public static int HotDogs;
    public GameObject GHat;
    public GameObject GHatUI;
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
}
