using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PlayerPickup : MonoBehaviour
{

    public TMP_Text indicator;
    bool inRange = false;

    private void OnTriggerEnter(Collider other)
    {
        Dropoff pickup = other.GetComponent<Dropoff>();
        if (pickup != null && pickup.canPickup)
        {
            inRange = true;
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inRange=false;
    }

    private void Update()
    {
        if (inRange == true &&  Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(" has been pickedup");
        }
    }
}
