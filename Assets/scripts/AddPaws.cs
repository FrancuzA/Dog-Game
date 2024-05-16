using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPaws : MonoBehaviour
{
    public GameObject modulePrefab; 
    public Transform playerTail; 
    public Transform playerHead; 
    public float distanceBetweenModules =0.33f;
    public Transform player;
    
    public float drift1 =0.41f;
    public float drift2 = -0.055f;


    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnModule();
        }
    }

    public void SpawnModule()
    {
        if(sklep.HotDogs > 0) {
        Destroy(playerTail.GetComponent<HingeJoint>());

            
        Vector3 tailPosition = playerTail.localPosition + new Vector3(0, 0f, -distanceBetweenModules);
        playerTail.localPosition = tailPosition;
        //playerHead.localRotation = Quaternion.Euler(-90,0,0);
        GameObject newModule = Instantiate(modulePrefab, playerTail.position + new Vector3(-drift1,-0.01f,drift2), Quaternion.Euler(0f, 92f,0f));
            
        FixedJoint joint = newModule.GetComponent<FixedJoint>();
        joint.connectedBody = playerHead.GetComponent<Rigidbody>();


        Destroy(playerTail.GetComponent<FixedJoint>());
        FixedJoint tailHinge = playerTail.gameObject.AddComponent<FixedJoint>();
        tailHinge.connectedBody = newModule.GetComponent<Rigidbody>();
       

        /*JointSpring hingeSpring = tailHinge.spring;
        hingeSpring.spring = springforce;
        hingeSpring.damper = damperforce;
        tailHinge.spring = hingeSpring;

        JointLimits jointLimits = tailHinge.limits;
        jointLimits.max = 15f;
        jointLimits.min = -15f;
        tailHinge.limits = jointLimits;*/

        playerHead = newModule.transform;

        newModule.transform.SetParent(player);
        }
        else
        {
            Debug.Log("not enought resources!!");
        }
    }
}
