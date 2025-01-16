using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractive
{
    [SerializeField] DialoguesSO myDialogue;
    [SerializeField] float turnTime;
    [SerializeField] Transform cameraPoint;

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

    void Interaction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Collider coll = Physics.OverlapSphere();

            //if (coll.TryGetComponent(out IInteractive interactive))
            //{
            //    interactive.Interact();
            //}
        }
    }

    public void Interact()
    {
        throw new System.NotImplementedException();
    }
}
