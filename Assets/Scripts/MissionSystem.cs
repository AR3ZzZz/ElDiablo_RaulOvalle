using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionSystem : MonoBehaviour
{
    [SerializeField] private EventManagerSO eventManager;
    [SerializeField] private ToggleMission[] missionToggles; 
    private void OnEnable()
    {
        eventManager.OnNewMission += OnMissionToggle;
    }

    private void OnMissionToggle(MissionSO mission)
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
