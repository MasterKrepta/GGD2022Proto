using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinAI : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;
    public float moveSpeed;

    [SerializeField]
     EnemyStates state = EnemyStates.CHASING;

    public float dist;

    public float attackDist = 3f;
    public float attackDelay;
    bool canAttack = true;
    Animator anim;

    enum EnemyStates
    {
        CHASING,
        ATTACKING
    }
    // Start is called before the first frame update
    void Start()
    {  //might be a problem since we have two players tagged, going to use the ineficient way instead
        //target = GameObject.FindGameObjectWithTag("Player").transform;
        target = GameObject.Find("DreamChild").transform;
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        
        agent.speed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
         dist = Vector3.Distance(transform.position, target.position);

        switch (state)
        {
            case EnemyStates.CHASING:
                agent.SetDestination(target.position);
              
              

                if (dist <= attackDist)
                {
                    state = EnemyStates.ATTACKING;
                }
                break;
            case EnemyStates.ATTACKING:
                if (canAttack)
                {
                    anim.SetTrigger("Attack");
                    StartCoroutine(Cooldown());
                }
                agent.isStopped = true;
                

                if (dist > attackDist)
                {
                    agent.isStopped = false;
                    state = EnemyStates.CHASING;
                }
                break;
            default:
                break;
        }
      
    }

    IEnumerator  Cooldown()
    {
        canAttack = false;
        yield return new WaitForSeconds(attackDelay);
        canAttack = true;
    }
}
