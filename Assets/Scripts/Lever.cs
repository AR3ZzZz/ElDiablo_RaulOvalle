using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour, IInteractive
{
    [SerializeField] Texture2D interactionIcon;
    [SerializeField] Texture2D defaultIcon;
    [SerializeField] GameObject puerta;
    Outline outline;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }
    public void Interact(Transform interactor)
    {
        Destroy(puerta.gameObject);
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

}
