using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EventManager")]
public class EventManagerSO : ScriptableObject
{
    public event Action<MissionSO> OnNewMission;
    public event Action<MissionSO> OnUpdateMission;
    public event Action<MissionSO> OnEndMission;
    public void NewMission(MissionSO mission)
    {
        OnNewMission?.Invoke(mission);//?. -> Invocacion Segura
    }

    public void UptadeMission(MissionSO mission)
    {
        OnUpdateMission?.Invoke(mission);
    }
    public void EndMission(MissionSO mission)
    {
        OnEndMission?.Invoke(mission);
    }
}
