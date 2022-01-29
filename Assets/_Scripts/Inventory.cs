using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Inventory: MonoBehaviour
{
    public static Inventory Instance;

    public List<string> inventoryNames = new List<string>();
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }
    
    public   void PickupItem(Item item)
    {
        inventoryNames.Add(item.item.ToString());
        
    }
}
