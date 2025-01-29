using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractive
{
    [SerializeField] EventManagerSO eventManager;
    [SerializeField] MissionSO myMission;
    [SerializeField] DialoguesSO initialDialogue;
    [SerializeField] DialoguesSO lastDialogue;
    [SerializeField] float turnTime;
    [SerializeField] Transform cameraPoint;

    [SerializeField] DialoguesSO curretDialogue;

    private void Awake()
    {
        curretDialogue = initialDialogue;
    }
    private void OnEnable()
    {
        eventManager.OnEndMission += SwapDialogue;
    }

    private void SwapDialogue(MissionSO missionFinished)
    {
        if (myMission == missionFinished)
        {
            curretDialogue = lastDialogue;
        }
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
