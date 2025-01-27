using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EventManager")]
public class EventManagerSO : ScriptableObject
{
    public event Action<MissionSO> OnNewMission;
    public void NewMission(MissionSO mission)
    {
        OnNewMission?.Invoke(mission);//?. -> Invocacion Segura
    }
}
