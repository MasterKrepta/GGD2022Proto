using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public string AttackAnimName;

    public void BeginAttack(Animator anim)
    {
        anim.SetTrigger(AttackAnimName);
    }

}
