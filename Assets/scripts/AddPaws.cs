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
      
        GameObject newModule = Instantiate(modulePrefab, playerHead.position, Quaternion.identity);

       
        Destroy(playerTail.GetComponent<HingeJoint>());

       
        Vector3 tailPosition = playerTail.localPosition - playerTail.up * distanceBetweenModules;
        playerTail.localPosition = tailPosition;

       
        HingeJoint hinge = newModule.AddComponent<HingeJoint>();
        hinge.connectedBody = playerHead.GetComponent<Rigidbody>();

        
        HingeJoint tailHinge = playerTail.gameObject.AddComponent<HingeJoint>();
        tailHinge.connectedBody = newModule.GetComponent<Rigidbody>();
        tailHinge.axis.x = 0;
        tailHinge.axis.y = 1;
        
        playerTail = newModule.transform;

        newModule.transform.SetParent(player);
    }
}
