using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform realWeapon;
    public Transform BOW;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //            FindObjectOfType<PlayerAttack>().canAttack = true;
            try
            {
                GameObject.Find("RealBow").SetActive(false);
                GameObject.Find("RealSpell").SetActive(false);
            }
            catch (System.Exception)
            {

                
            }
            realWeapon.gameObject.SetActive(true);
            BOW.gameObject.SetActive(true);
            Destroy(this.gameObject);

            
        }
    }
}
