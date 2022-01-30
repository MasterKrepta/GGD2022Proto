using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{


    Animator anim;
    public bool canAttack;

    public GameObject weaponParent;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (weaponType == weaponTypes.None) return;

        if (Input.GetKeyDown(KeyCode.Space) && canAttack)
        {

            weaponParent.GetComponentInChildren<Attack>().BeginAttack(anim);
            //anim.SetTrigger(weaponType.ToString());
            StartCoroutine(Cooldown());
        }
        
    }

    IEnumerator Cooldown()
    {
        canAttack = false;
        yield return new WaitForSeconds(0.5f);
        canAttack = true;
    }
}
