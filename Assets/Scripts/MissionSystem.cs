using System;
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
        eventManager.OnUpdateMission += UpdateMissionToggle;
        eventManager.OnEndMission += EndMissionToggle;
    }



    private void OnMissionToggle(MissionSO mission)
    {
        missionToggles[mission.missionIndex].MissionText.text = mission.initialOrder;

        if (mission.tieneRepeticion)
        {
            missionToggles[mission.missionIndex].MissionText.text += "(" +mission.currentRepetition + "/" + mission.repetitionTimes + ")";
        }

        missionToggles[mission.missionIndex].gameObject.SetActive(true);
    }

    private void UpdateMissionToggle(MissionSO mission)
    {
        missionToggles[mission.missionIndex].MissionText.text = mission.initialOrder;
        missionToggles[mission.missionIndex].MissionText.text += "(" + mission.currentRepetition + "/" + mission.repetitionTimes + ")";
    }

    private void EndMissionToggle(MissionSO mission)
    {
        missionToggles[mission.missionIndex].ToggleVisual.isOn = true;
        missionToggles[mission.missionIndex].MissionText.text = mission.finalOrder;
    }

}
