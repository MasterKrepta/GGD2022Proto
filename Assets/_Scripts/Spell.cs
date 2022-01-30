using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public Transform realWeapon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("RealBow").SetActive(false);
            realWeapon.gameObject.SetActive(true);
            Destroy(this.gameObject);


        }
    }
}
