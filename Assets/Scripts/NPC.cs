using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [SerializeField] float turnTime;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public void Interact(Transform whoInteracts)
    {
        Debug.Log("El diablo papa klk");
        transform.DOLookAt(whoInteracts.position,turnTime, AxisConstraint.Y);
    }
}
