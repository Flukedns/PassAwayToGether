using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class AiManager2 : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    private Animator animator;

    public BoxCollider box;
    
    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;
    
    //Attacking
    public float timeBetweenAttacks;
    private bool alreadyAttacks;
    
    //States
    public float sightRange, attackRange;
    private bool playerInSightRange, playerInAttackRange;

     void Start()
     {
         animator = GetComponent<Animator>();
         box = GetComponentInChildren<BoxCollider>();
     }

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange)
        {
            Patrolling();
            animator.SetBool("IsWalk", true);
        }
        if (playerInSightRange && !playerInAttackRange)
        {
            Pursue();
        }
        if (playerInSightRange && playerInAttackRange)
        {
            AttackPlayer();
        }
        
    }

    void Patrolling()
    {
        if (!walkPointSet)
        {
            SearchWalkPoint();
        }

        if (walkPointSet)
        {
            agent.SetDestination(walkPoint);
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
        animator.SetBool("IsWalk", true);
    }

    void SearchWalkPoint()
    {
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        float randomZ = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, - transform.up,2f, whatIsGround))
        {
            walkPointSet = true;
        }
    }

   
    void Pursue()
    {
        agent.SetDestination(player.position);
        animator.SetBool("IsWalk", true);
    }
    
    public void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        
        transform.LookAt(player);

        if (!alreadyAttacks)
        {
            //Attack code
            animator.SetTrigger("Attack");

            alreadyAttacks = true;
            Invoke(nameof(ResetAttack),timeBetweenAttacks);
        }
    }

    void EnableAttack()
    {
        box.enabled = true;
    }

    void DisableAttack()
    {
        box.enabled = false;
    }

    void ResetAttack()
    {
        alreadyAttacks = false;
        //animator.SetBool("IsAttack", false);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
