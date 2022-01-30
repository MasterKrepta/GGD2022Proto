using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackAnims : MonoBehaviour
{
    public Transform Arrow;
    public Transform Spell;

    public Transform spawnpoint;
    public void FireBow()
    {
        Instantiate(Arrow, spawnpoint.position, spawnpoint.rotation);
    }
    
    public  void FireSpell()
    {
        Instantiate(Spell, spawnpoint.position, spawnpoint.rotation);
    }

    public void Die()
    {
        GetComponent<NavMeshAgent>().speed = 0;
    }
}
