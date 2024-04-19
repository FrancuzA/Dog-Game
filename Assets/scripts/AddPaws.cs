using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPaws : MonoBehaviour
{
    public GameObject modulePrefab; 
    public Transform playerTail; 
    public Transform playerHead; 
    public float distanceBetweenModules = 1f;
    public Transform player;
    float springforce = 10f;
    float damperforce = 3f;

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnModule();
        }
    }

    void SpawnModule()
    {
      
        Destroy(playerTail.GetComponent<HingeJoint>());

       
        Vector3 tailPosition = playerTail.localPosition - playerTail.up * distanceBetweenModules;
        playerTail.localPosition = tailPosition;

        GameObject newModule = Instantiate(modulePrefab, playerHead.position + new Vector3(0, distanceBetweenModules/2,0), Quaternion.identity);

        HingeJoint hinge = newModule.GetComponent<HingeJoint>();
        hinge.connectedBody = playerHead.GetComponent<Rigidbody>();
        hinge.anchor = new Vector3 (0,0, -0.5f);

        
        HingeJoint tailHinge = playerTail.gameObject.AddComponent<HingeJoint>();
        tailHinge.connectedBody = newModule.GetComponent<Rigidbody>();
        tailHinge.axis = new Vector3(0f, 0f, 1f);
        tailHinge.useSpring = true;
        tailHinge.useLimits = true;

        JointSpring hingeSpring = tailHinge.spring;
        hingeSpring.spring = springforce;
        hingeSpring.damper = damperforce;
        tailHinge.spring = hingeSpring;

        JointLimits jointLimits = tailHinge.limits;
        jointLimits.max = 15f;
        jointLimits.min = -15f;
        tailHinge.limits = jointLimits;




        playerTail = newModule.transform;

        newModule.transform.SetParent(player);
    }
}
