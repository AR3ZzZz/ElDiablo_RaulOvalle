using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private PatrolSystem patrol;
    private CombatSystem combat;
    private Transform target;

    public PatrolSystem Patrol { get => patrol; set => patrol = value; }
    public CombatSystem Combat { get => combat; set => combat = value; }
    public Transform Target { get => target; set => target = value; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CombatStart(Transform target)
    {
        patrol.enabled = false;
        combat.enabled = true;
        this.target = target;

    }
}
