using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("Dialogue"))]

public class DialoguesSO : ScriptableObject
{
    [TextArea]
    public string[] sentences;
    public AudioClip[] sounds;
    public float timeBetweenLetters;

    public bool hasMission;
    public MissionSO mission;
}
