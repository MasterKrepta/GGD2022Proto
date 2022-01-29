using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyItems  {
    NONE,
    GAMEBOY,
    WAND,
    FLASHLIGHT,
    SWORD,
    SMALLKEY,
    GOLDKEY

}


public class Dropoff : MonoBehaviour
{
    public bool canPickup = false;
    public KeyItems ItemNeeded = KeyItems.NONE;
    public GameObject KeyItemGraphic;
    Canvas hintMessage;


    private void Start()
    {
        KeyItemGraphic.SetActive(false);
        hintMessage = GetComponentInChildren<Canvas>();
        hintMessage.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {Debug.Log(ItemNeeded.ToString());
        if (other.CompareTag("Player") && Inventory.Instance.inventoryNames.Contains(ItemNeeded.ToString()))// If other has required item
        {
            hintMessage.enabled = false;
            DropoffItem();
            
            canPickup = true;
            
        }
        else
        {
            //display hint messsage
            hintMessage.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canPickup = false;
            hintMessage.enabled = false;
            //todo hide hint message
        }
    }

    public void DropoffItem()
    {
       KeyItemGraphic?.SetActive(true);
        GetComponent<Collider>().enabled = false;
    }
}
