using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("Mission"))]
public class MissionSO : ScriptableObject
{
    public string initialOrder;
    public string finalOrder;
    public bool tieneRepeticion;
    public int repetitionTimes;
    public int missionIndex;
    
    public int currentRepetition;
}
