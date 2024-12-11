using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    Camera cam;
    NavMeshAgent agent;
    Transform lastHitted;
    [SerializeField] float interactionDistance;

    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Time.timeScale == 0)
        {
            PointAndClickMovement();
        }
        TryToInteract();
    }

    private void TryToInteract()
    {
        if (lastHitted != null &&  lastHitted.TryGetComponent(out NPC npc))
        {
            agent.stoppingDistance = interactionDistance;

            if (!agent.pathPending &&  agent.remainingDistance <= agent.stoppingDistance)
            {
                npc.Interact(transform);

                lastHitted = null;
            }
        }
        else if (lastHitted)
        {
            agent.stoppingDistance = 0;
        }
    }

    private void PointAndClickMovement()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                agent.SetDestination(hitInfo.point);
                lastHitted = hitInfo.transform;
            }

        }
    }
}
