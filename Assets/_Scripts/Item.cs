using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public KeyItems item = KeyItems.NONE;
    public GameObject uiGraphic;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (uiGraphic != null)
            {
                uiGraphic.SetActive(true);
            }

            Inventory.Instance.PickupItem(this);
            Destroy(gameObject);
        }
    }
}
