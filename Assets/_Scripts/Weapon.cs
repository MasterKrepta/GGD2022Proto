using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform realWeapon;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            realWeapon.gameObject.SetActive(true);
            Destroy(this.gameObject);

        }
    }
}
