using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour, IInteractive
{

    Outline outline;
    bool open;
    [SerializeField] Texture2D interactionIcon;
    [SerializeField] Texture2D defaultIcon;
    [SerializeField] GameObject openChest;
    [SerializeField] GameObject closedChest;
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
        open = true;
        openChest.SetActive(true);
        closedChest.SetActive(false);
    }
}
