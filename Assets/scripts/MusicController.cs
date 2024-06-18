using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public int musicValue;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "0")
        {
            musicValue =0;
            Debug.Log("New music Value: " + musicValue);
        }

        if (other.gameObject.tag == "20")
        {
            musicValue =20;
            Debug.Log("New music Value: " + musicValue);
        }

        if (other.gameObject.tag == "40")
        {
            musicValue =40;
            Debug.Log("New music Value: " + musicValue);
        }

        if (other.gameObject.tag == "60")
        {
            musicValue =60;
            Debug.Log("New music Value: " + musicValue);
        }

        if (other.gameObject.tag == "80")
        {
            musicValue =80;
            Debug.Log("New music Value: " + musicValue);
        }

        if (other.gameObject.tag == "100")
        {
            musicValue =100;
            Debug.Log("New music Value: " + musicValue);
        }
    }
}
