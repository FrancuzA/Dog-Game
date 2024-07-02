using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loader_controller : MonoBehaviour
{
    [SerializeField] public static bool pl_activ = false;
    [SerializeField] public static bool ay_activ = false;
     public GameObject loadingScreen;
     public GameObject mainMenu;
     public Image progressBar;
     public Transform front;
     public GameObject paruwabar;
     public Image paruwafill;

    public float fill =0;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (pl_activ== true && ay_activ == true)
        {
            fill += 0.005f;
            paruwabar.SetActive(true);
            paruwafill.fillAmount = fill;
        }
        else
        {
            fill = 0;
            paruwafill.fillAmount = 0;
            paruwabar.SetActive(false);
        }
        if(fill >= 1)
        {
            paruwabar.SetActive(false);
            pl_activ = false;
            ay_activ = false;
            LoadLevelAnim("tutorial");
        }
    }

    public void LoadLevelAnim(string levelToLoad)
    {
        mainMenu.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(AsyncLoad(levelToLoad));
    }

    IEnumerator AsyncLoad(string levelToLoad)
    {
        yield return new WaitForSecondsRealtime(5f);
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);

        while (!loadOperation.isDone)
        {
            float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            progressBar.fillAmount = progressValue;
            front.localPosition.Set(progressValue*700f,0f,0f);
            Debug.Log("Progress value is " +  progressValue);
            Debug.Log(front.localPosition);
            yield return null;
        }
    }
}
