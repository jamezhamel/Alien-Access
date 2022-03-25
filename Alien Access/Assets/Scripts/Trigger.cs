using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Trigger : MonoBehaviour
{

    public GameObject TriggeredObject;
    


    private void On2dTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            //TriggerMovingPlatform triggerMovingPlatform = TriggeredObject.GetComponent<TriggerMovingPlatform>();
            //triggerMovingPlatform.enabled = true;

            //TriggeredObject.GetComponent<TriggerMovingPlatform>().activate();

            //TriggerMovingPlatform TR = TriggeredObject.GetComponent<TriggerMovingPlatform>();
            //TR.activate();
        }

    }
}
