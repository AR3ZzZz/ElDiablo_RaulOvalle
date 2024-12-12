using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerVisual : MonoBehaviour
{
    Animator animator;
    NavMeshAgent agent;

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponentInParent<NavMeshAgent>();
    }

    void Update()
    {
        animator.SetFloat("Velocity",agent.velocity.magnitude / agent.speed);
    }
}
