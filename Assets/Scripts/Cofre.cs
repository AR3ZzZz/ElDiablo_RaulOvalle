using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Cofre : MonoBehaviour, IInteractive
{

    Outline outline;
    bool open;
    [SerializeField] Texture2D interactionIcon;
    [SerializeField] Texture2D defaultIcon;
    [SerializeField] GameObject openChest;
    [SerializeField] GameObject closedChest;

    [SerializeField] private EventManagerSO eventManager;
    [SerializeField] private MissionSO mission;
    void Start()
    {
        open = false;
        openChest.SetActive(false);
        closedChest.SetActive(true);
        outline = GetComponent<Outline>();
    }

    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        Cursor.SetCursor(interactionIcon, Vector2.zero, CursorMode.Auto);
        outline.enabled = true;
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(defaultIcon, Vector2.zero, CursorMode.Auto);
        outline.enabled = false;
    }

    public void Interact(Transform interactor)
    {
        


        if (!open)
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

            openChest.SetActive(true);
            closedChest.SetActive(false);
            open = true;
        }
    }
}
