using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    public GameObject player;
    public GameObject legFL;
    public GameObject legFR;
    public GameObject legML;
    public GameObject legMR;
    public GameObject legBL;
    public GameObject legBR;
    public GameObject front;
    private float playerangle = 0;
    void Start()
    {
        
    }

    void Update()
    {
        playerangle =  front.GetComponent<Transform>().rotation.z;
        if(Input.GetKey(KeyCode.Q))
        {
            legBL.transform.Rotate(new Vector3(-1,0,0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            legML.transform.Rotate(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.E))
        {
            legFL.transform.Rotate(new Vector3(-1, 0,0));
        }
        if (Input.GetKey(KeyCode.P))
        {
            legBR.transform.Rotate(new Vector3(-1,0,0));
        }
        if (Input.GetKey(KeyCode.O))
        {
            legMR.transform.Rotate(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.I))
        {
            legFR.transform.Rotate(new Vector3(-1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.Translate(new Vector3(0, 1f,0));
            front.transform.Rotate(new Vector3(0, 0,-playerangle));
        }
        if (Input.GetKey(KeyCode.G))
        {
            front.transform.Rotate(new Vector3(0, 0, -0.1f));
        }
        if (Input.GetKey(KeyCode.H))
        {
            front.transform.Rotate(new Vector3(0, 0, 0.1f));
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            legBL.SetActive(!legBL.activeSelf);
            legBR.SetActive(!legBR.activeSelf);
            legFL.SetActive(!legFL.activeSelf);
            legFR.SetActive(!legFR.activeSelf);
            legML.SetActive(!legML.activeSelf);
            legMR.SetActive(!legMR.activeSelf); 
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("lvl1");
        }
    }
}
