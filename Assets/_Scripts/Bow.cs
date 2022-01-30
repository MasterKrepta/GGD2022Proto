using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Transform realWeapon;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            try
            {
                GameObject.Find("RealSword").SetActive(false);
                GameObject.Find("RealSpell").SetActive(false);
            }
            catch (System.Exception)
            {

                
            }
            
            realWeapon.gameObject.SetActive(true);
            Destroy(this.gameObject);


        }
    }

  
}
