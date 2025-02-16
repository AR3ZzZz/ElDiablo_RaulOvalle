using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem system;

    [SerializeField] EventManagerSO eventManager;
    [SerializeField] GameObject dialogueFrame;
    [SerializeField] TMP_Text dialogueText;
    [SerializeField] Transform npcCamera;

    bool writting;
    int currentSentenceIndex;

    DialoguesSO currentDialogue;

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

    
   
    public void StartDialogue(DialoguesSO dialogue, Transform cameraPoint)
    {
        Time.timeScale = 0;
        currentDialogue = dialogue;
        dialogueFrame.SetActive(true);

        npcCamera.SetPositionAndRotation(cameraPoint.position, cameraPoint.rotation);

        StartCoroutine(WriteSentence());
    }

    IEnumerator WriteSentence()
    {
        //audioSource.clip = dialogoActual.frasesClips[indiceFraseActual];
        //audioSource.Play();

        writting = true;
        dialogueText.text = string.Empty;
        char[] lettersOfSentence =  currentDialogue.sentences[currentSentenceIndex].ToCharArray();

        foreach (char letters in lettersOfSentence)
        {
            dialogueText.text += letters;
            yield return new WaitForSecondsRealtime(currentDialogue.timeBetweenLetters);
        }
        writting = false;
    }

    public void CompleteSentence()
    {
        dialogueText.text = currentDialogue.sentences[currentSentenceIndex];

        StopAllCoroutines();

        writting = false;
    }

    public void NextSentence()
    {
        if (!writting)
        {
            currentSentenceIndex++;
            if (currentSentenceIndex < currentDialogue.sentences.Length)
            {
                StartCoroutine(WriteSentence());
            }
            else
            {
                EndDialogue();
            }
        }
        else
        {
            CompleteSentence();
        }
    }

    void EndDialogue()
    {
        Time.timeScale = 1;
        currentSentenceIndex = 0;        
        dialogueFrame?.SetActive(false);

        if (currentDialogue.hasMission)
        {
            eventManager.NewMission(currentDialogue.mission);
        }
        currentDialogue = null ;
    }
}
