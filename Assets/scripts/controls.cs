using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class controls : MonoBehaviour
{
    public GameObject text;
    public GameObject ikon;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            text.SetActive(!text.activeInHierarchy);
            ikon.SetActive(!ikon.activeInHierarchy);
        }
    }
}
