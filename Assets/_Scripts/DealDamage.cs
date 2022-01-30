using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Animator>().SetTrigger("Die");
            other.gameObject.tag = "Untagged";
            //Destroy(other.gameObject);
        }

        if (other.CompareTag("Player"))
        {
            other.GetComponent<Animator>().SetTrigger("Hit");
            Debug.Log("PlayerTakesDamage");
        }
    }
}
