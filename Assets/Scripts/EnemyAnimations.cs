using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAnimations : MonoBehaviour
{
    Animator animator;
    [SerializeField] NavMeshAgent agent;

    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        animator.SetFloat("Blend", agent.velocity.magnitude / agent.speed);
    }
}
