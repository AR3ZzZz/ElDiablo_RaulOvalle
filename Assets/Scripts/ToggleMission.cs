using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMission : MonoBehaviour
{

    [SerializeField] private TMP_Text missionText;
    private Toggle toggleVisual;

    public Toggle ToggleVisual { get => toggleVisual;}
    public TMP_Text MissionText { get => missionText;}

    private void Awake()
    {
        toggleVisual = GetComponent<Toggle>();
    }
}
