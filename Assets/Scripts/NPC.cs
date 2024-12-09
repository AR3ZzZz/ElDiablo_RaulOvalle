using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] DialoguesSO myDialogue;
    [SerializeField] float turnTime;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public void Interact(Transform whoInteracts)
    {
        transform.DOLookAt(whoInteracts.position,turnTime, AxisConstraint.Y).OnComplete(StartInteraction);
    }

    void StartInteraction()
    {
        Debug.Log("El diablo papa klk");
    }
}
