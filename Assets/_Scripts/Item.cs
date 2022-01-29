using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public KeyItems item = KeyItems.NONE;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Inventory.Instance.PickupItem(this);
            Destroy(gameObject);
        }
    }
}
