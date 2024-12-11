using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName =("Dialogue"))]

public class DialoguesSO : ScriptableObject
{
    [TextArea]
    public string[] sentences;

    public float timeBetweenLetters;
}
