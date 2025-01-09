using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CombatSystem : MonoBehaviour
{
    [SerializeField] private Enemy main;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] float combatSpeed;

    private void Awake()
    {
        main.Combat = this;   
    }


    private void OnEnable()
    {       
        agent.speed = combatSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(main.Target.position);
    }
}
