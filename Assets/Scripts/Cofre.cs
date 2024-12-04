using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{

    Outline outline;
    [SerializeField] Texture2D interactionIcon;
    [SerializeField] Texture2D defaultIcon;
    void Start()
    {
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
}
