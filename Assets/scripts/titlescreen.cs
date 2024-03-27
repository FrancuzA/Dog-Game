using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlescreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void funkcja1()
    {
        SceneManager.LoadSceneAsync("lvl1");
        Debug.Log("LOADING SCENE");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
