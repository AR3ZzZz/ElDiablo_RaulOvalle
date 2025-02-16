using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class CombatSystem : MonoBehaviour
{
    [SerializeField] private Enemy main;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] float combatSpeed;
    [SerializeField] float attackDistance;
    [SerializeField] float attackDmg;
    [SerializeField] Animator animator;
    [SerializeField] GameObject fireBall;

    [SerializeField] GameObject attackPoint;
    private void Awake()
    {
        main.Combat = this;   
    }


    private void OnEnable()
    {       
        agent.speed = combatSpeed;
        agent.stoppingDistance = attackDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (main.Target != null && agent.CalculatePath(main.Target.position, new NavMeshPath()))
        {
            FocusTarget();

            agent.SetDestination(main.Target.position);

            if (!agent.pathPending && agent.remainingDistance <= attackDistance)
            {
                agent.isStopped = true;
                animator.SetBool("attacking", true);
            }
        }
        else
        {
            main.PatrolStart();
        }
    }

    private void FocusTarget()
    {
        Vector3 targetDirection = (main.Target.position - transform.position).normalized;
        targetDirection.y = 0;

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        transform.rotation = targetRotation;
    }
    #region Se ejecutan por eventos de animacion
    void Attack()
    {
        //Physics.OverlapSphere();
        main.Target.GetComponent<Player>().MakeDmg(attackDmg);
    }
    void FireballAttack()
    {
        GameObject clon = fireBall;
        Instantiate(clon, attackPoint.transform.position, quaternion.identity);
    }
    void EndAttackAnimation()
    {
        animator.SetBool("attacking", false);
        agent.isStopped = false;

    }
    #endregion
}
