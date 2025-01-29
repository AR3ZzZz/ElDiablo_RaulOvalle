using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour,IInteractive
{
    private Outline outline;
    [SerializeField] private EventManagerSO eventManager;
    [SerializeField] private MissionSO mission;

    public void Interact(Transform interactor)
    {
        mission.currentRepetition++;

        if (mission.currentRepetition < mission.repetitionTimes)
        {
            eventManager.UptadeMission(mission);            
        }
        else
        {
            eventManager.EndMission(mission);
        }

        Destroy(gameObject);
    }

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void OnMouseEnter() => outline.enabled = true;

    private void OnMouseExit() => outline.enabled = false;  
    
        
    



}
