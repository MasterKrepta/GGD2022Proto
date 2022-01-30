using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public Transform realWeapon;
    public GameObject UIGraphic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            try
            {
                GameObject.Find("RealBow").SetActive(false);
                GameObject.Find("RealSword").SetActive(false);
            }
            catch (System.Exception)
            {

                
            }
            
            realWeapon.gameObject.SetActive(true);
            UIGraphic.SetActive(true);
            Destroy(this.gameObject);


        }
    }
}
