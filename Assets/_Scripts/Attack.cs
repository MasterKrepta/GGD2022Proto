using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public string AttackAnimName;
    public Animator anim;
    public bool canAttack;
    


    private void Start()
    {
        //anim = GetComponent<Animator>();
        canAttack = true;
        GetComponent<AudioSource>().Play();
    }

    IEnumerator Cooldown()
    {
        canAttack = false;
        yield return new WaitForSeconds(0.5f);
        canAttack = true;
    }
    public void BeginAttack(Animator anim)
    {
        anim.SetTrigger(AttackAnimName);
        StartCoroutine(Cooldown());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canAttack)
        {

            BeginAttack(anim);
            
        }
    }

}
