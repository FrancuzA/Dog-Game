using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_control : MonoBehaviour
{
    public GameObject back;
    public float speed = 0.02f;
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            back.transform.Translate(new Vector3(speed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            back.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            back.transform.Translate(new Vector3(0f,-speed * Time.deltaTime, 0f));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            back.transform.Translate(new Vector3(0f, speed * Time.deltaTime, 0f));
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pl")
        {
            loader_controller.pl_activ = true;
        }
        Debug.Log("pl trigger entered!");
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "pl")
        {
            loader_controller.pl_activ = false;
            Debug.Log("pl trigger exited!");
        }
    }
}
