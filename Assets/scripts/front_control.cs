using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class front_control : MonoBehaviour
{
    public GameObject front;
    public float speed;
     void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            front.transform.Translate(new Vector3(speed*Time.deltaTime, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            front.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            front.transform.Translate(new Vector3(0f, -speed * Time.deltaTime, 0f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            front.transform.Translate(new Vector3(0f, speed * Time.deltaTime, 0f));
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ay")
        {
            loader_controller.ay_activ = true;
            Debug.Log("ay trigger entered!");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ay")
        {
            loader_controller.ay_activ = false;
            Debug.Log("ay trigger exited!");
        }
    }
}
