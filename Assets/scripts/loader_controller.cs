using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loader_controller : MonoBehaviour
{
    [SerializeField] public static bool pl_activ = false;
    [SerializeField] public static bool ay_activ = false;
    public GameObject loader;
    public Image fill;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (pl_activ== true && ay_activ == true)
        {
            loader.SetActive(true);
            fill.fillAmount += 0.005f;
        }
        else
        {
            loader.SetActive(false);
            fill.fillAmount = 0;
        }
        if(fill.fillAmount == 1)
        {
            SceneManager.LoadScene(1);
        }
    }
}
