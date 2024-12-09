using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem system;
    void Awake()
    {
        if (system == null)
        {
            system = this;
        }
        else 
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        
    }
    public void StartDialogue(DialoguesSO dialogue)
    {

    }
}
