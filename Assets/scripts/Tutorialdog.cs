using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorialdog : MonoBehaviour
{
    public GameObject player;
    public GameObject legFL;
    public GameObject legFR;
    public GameObject legML;
    public GameObject legMR;
    public GameObject legBL;
    public GameObject legBR;
    public GameObject front;
    public GameObject camera1;
    public GameObject EnergyUI;
    public GameObject CS1;
    public GameObject CS2;
    public GameObject TutTXTBG;
    public GameObject TutTXT1;
    public GameObject TutTXT2;
    public GameObject TutTXT3;
    public GameObject TutTXT4;
    public GameObject TutTXT5;
    public GameObject TutTXT6;   
    public GameObject TutTXT7;
    public GameObject TutTXT8;
    public GameObject TutTXT9;

    public UnityEngine.UI.Image EnergyBar;
    public static int Parowy = 0;
    public static int Buly = 0;
    private float playerangle = 0;
    public float EnergyDrain = 0.0001f;
    public bool Tut_leg1 = false;
    public bool Tut_leg2 = false;
    public bool Tut_leg3 = false;
    public bool Tut_leg4 = false;
    public bool Tut_leg5 = false;
    public bool Tut_leg6 = false;
    public bool Tut_started = false;
    public Quaternion camangle;
    public Rigidbody rb;

    void Start()
    {
        StartCoroutine(TutorialPhases());
    }

    // Update is called once per frame
    void Update()
    {
        playerangle = front.GetComponent<Transform>().rotation.z;
        if (Input.GetKey(KeyCode.Q) && Tut_leg2 == true)
        {
            legBL.transform.Rotate(new Vector3(-1, 0, 0));
            EnergyBar.fillAmount -= EnergyDrain;
            Tut_leg3 = true;

        }
        if (Input.GetKey(KeyCode.W) && Tut_leg1==true)
        {
            legML.transform.Rotate(new Vector3(-1, 0, 0));
            EnergyBar.fillAmount -= EnergyDrain;
            Tut_leg2 = true;
        }
        if (Input.GetKey(KeyCode.E) && Tut_started==true)
        {
            legFL.transform.Rotate(new Vector3(-1, 0, 0));
            EnergyBar.fillAmount -= EnergyDrain;
            Tut_leg1 = true;
        }
        if (Input.GetKey(KeyCode.P) && Tut_leg5 == true)
        {
            legBR.transform.Rotate(new Vector3(-1, 0, 0));
            EnergyBar.fillAmount -= EnergyDrain;
            Tut_leg6 = true;
        }
        if (Input.GetKey(KeyCode.O) && Tut_leg4 == true)
        {
            legMR.transform.Rotate(new Vector3(-1, 0, 0));
            EnergyBar.fillAmount -= EnergyDrain;
            Tut_leg5 = true;
        }
        if (Input.GetKey(KeyCode.I) && Tut_leg3 == true)
        {
            legFR.transform.Rotate(new Vector3(-1, 0, 0));
            EnergyBar.fillAmount -= EnergyDrain;
            Tut_leg4 = true;
        }
        if (Input.GetKey(KeyCode.G))
        {
            front.transform.Rotate(new Vector3(0, 0, -0.1f));
        }
        if (Input.GetKey(KeyCode.H))
        {
            front.transform.Rotate(new Vector3(0, 0, 0.1f));
        }

        camangle = camera1.transform.localRotation;
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            //pozycje kamery
            //camera1.transform.SetLocalPositionAndRotation(new Vector3(0, -1.6f, 0.6f), new Quaternion(0, 0.81915f, 0.57358f, 0));//przód
            //camera1.transform.SetLocalPositionAndRotation(new Vector3(0f, 1.6f, 0.6f), new Quaternion(0.81915f, 0, 0, 0.57358f));//tył
            //camera1.transform.SetLocalPositionAndRotation(new Vector3(-1.6f, -0.2f, 0.6f), new Quaternion(0.57923f, 0.57923f, 0.40558f, 0.40558f));//lewo
            //camera1.transform.SetLocalPositionAndRotation(new Vector3(1.6f, -0.2f, 0.6f), new Quaternion(0.57923f, -0.57923f, -0.40558f, 0.40558f));//prawo
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bula")
        {
            other.gameObject.SetActive(false);
            Buly++;
            Debug.Log("zebrano bule!");
        }

        if (other.gameObject.tag == "parowa")
        {
            other.gameObject.SetActive(false);
            Parowy++;
            Debug.Log("zebrano parowe!!");
        }
    }


    IEnumerator TutorialPhases()
    {
        CS1.SetActive(true);
        yield return new WaitForSecondsRealtime(7f);
        CS1.SetActive(false);
        CS2.SetActive(true);
        yield return new WaitForSecondsRealtime(6f);
        CS2.SetActive(false);  
        TutTXTBG.SetActive(true);
        TutTXT1.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        TutTXT1.SetActive(false);
        Tut_started = true;
        camera1.transform.SetLocalPositionAndRotation(new Vector3(-1.6f, -0.2f, 0.6f), new Quaternion(0.57923f, 0.57923f, 0.40558f, 0.40558f));
        TutTXT2.SetActive(true);
        yield return new WaitUntil(() => Tut_leg1 == true);
        TutTXT2.SetActive(false);
        TutTXT3.SetActive(true);
        yield return new WaitUntil(() => Tut_leg2 == true);
        TutTXT3.SetActive(false);
        TutTXT4.SetActive(true);
        yield return new WaitUntil(() => Tut_leg3 == true);
        TutTXT4.SetActive(false);
        TutTXT5.SetActive(true);
        camera1.transform.SetLocalPositionAndRotation(new Vector3(1.6f, -0.2f, 0.6f), new Quaternion(0.57923f, -0.57923f, -0.40558f, 0.40558f));
        yield return new WaitUntil(() => Tut_leg4 == true);
        TutTXT5.SetActive(false);
        TutTXT6.SetActive(true);
        yield return new WaitUntil(() => Tut_leg5 == true);
        TutTXT6.SetActive(false);
        TutTXT7.SetActive(true);
        yield return new WaitUntil(() => Tut_leg6 == true);
        TutTXT7.SetActive(false);
        rb.isKinematic = false;
        camera1.transform.SetLocalPositionAndRotation(new Vector3(0f, 1.6f, 0.6f), new Quaternion(0.81915f, 0, 0, 0.57358f));
        EnergyUI.SetActive(true);
        TutTXT8.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        TutTXT8.SetActive(false);
        TutTXT9.SetActive(true);
        yield return new WaitForSecondsRealtime(10f);
        TutTXT9.SetActive(false);
        TutTXTBG.SetActive(false);
        yield return new WaitUntil(() => Buly==1 && Parowy==1);
        SceneManager.LoadScene(2);
    }
}
