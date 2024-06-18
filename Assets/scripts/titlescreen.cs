using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlescreen : MonoBehaviour
{
    public Transform Camera1;
    bool inSettings = false;
    public GameObject menucanva;
    public GameObject menudog;
    public GameObject settingsdog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(inSettings == false) 
            {
                menudog.SetActive(false);
                settingsdog.SetActive(true);
                menucanva.SetActive(false);
                inSettings = true;
            Vector3 settingscords = new Vector3(42.23f, 2.58f, -22.89f);
            Debug.Log("escape");
            Camera1.position = settingscords;
            }
            else
            {
                menudog.SetActive(true);
                settingsdog.SetActive(false);
                menucanva.SetActive(true);
                Vector3 menucords = new Vector3(-1.09f, 2.36f, -3.38f);
                inSettings=false;
                Camera1.position =menucords;
            }
        } 
    }
    
}
