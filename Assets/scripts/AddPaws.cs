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
    float springforce = 10f;
    float damperforce = 3f;
    public float drift1 =0.41f;
    public float drift2 = -0.073f;


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

        GameObject newModule = Instantiate(modulePrefab, playerTail.position + new Vector3(-drift1,-0.01f,drift2), Quaternion.Euler(0f, 90f,0f));
            
        HingeJoint hinge = newModule.GetComponent<HingeJoint>();
        hinge.connectedBody = playerHead.GetComponent<Rigidbody>();
        hinge.anchor = new Vector3 (0,0f, 0.046f);

        
        HingeJoint tailHinge = playerTail.gameObject.AddComponent<HingeJoint>();
        tailHinge.connectedBody = newModule.GetComponent<Rigidbody>();
        tailHinge.axis = new Vector3(0f, 0f, 1f);
        tailHinge.anchor = new Vector3(-0.09f, -0.05f, 0);
        tailHinge.useSpring = true;
        tailHinge.useLimits = true;
        tailHinge.enablePreprocessing = false;

        JointSpring hingeSpring = tailHinge.spring;
        hingeSpring.spring = springforce;
        hingeSpring.damper = damperforce;
        tailHinge.spring = hingeSpring;

        JointLimits jointLimits = tailHinge.limits;
        jointLimits.max = 15f;
        jointLimits.min = -15f;
        tailHinge.limits = jointLimits;

        playerHead = newModule.transform;

        newModule.transform.SetParent(player);
        }
        else
        {
            Debug.Log("not enought resources!!");
        }
    }
}
