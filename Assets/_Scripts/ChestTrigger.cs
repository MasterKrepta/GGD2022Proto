using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    public Animator anim;


    private void OnEnable()
    {
        anim.SetTrigger("Open");
    }
}
