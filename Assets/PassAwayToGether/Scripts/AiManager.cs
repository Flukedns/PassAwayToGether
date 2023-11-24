using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class AiManager : MonoBehaviour
{
    private NavMeshAgent agent;

    private Transform player;

    public LayerMask whatIsGround, whatIsPlayer;
    
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

   /* void Seek(Vector3 location)
    {
        agent.SetDestination(location);
    }*/

    void Pursue()
    {
       /* Vector3 targetDir = player.transform.position - this.transform.position;
        float playerSpeed = player.GetComponent<NavMeshAgent>().velocity.magnitude;
        float lookAhead = targetDir.magnitude / (agent.speed + playerSpeed);
        Seek(player.transform.position + player.transform.position * lookAhead);*/
       agent.SetDestination(player.position);
    }
    
    public void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        
        transform.LookAt(player);

        if (!alreadyAttacks)
        {
            //Attack code
            
            
            
            alreadyAttacks = true;
            Invoke(nameof(ResetAttack),timeBetweenAttacks);
        }
    }

    void ResetAttack()
    {
        alreadyAttacks = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
