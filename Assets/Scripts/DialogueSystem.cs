using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem system;

    [SerializeField] GameObject dialogueFrame;
    [SerializeField] TMP_Text dailogueText;

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

    void Update()
    {
        
    }
   
    public void StartDialogue(DialoguesSO dialogue)
    {
        Time.timeScale = 0;
        currentDialogue = dialogue;
        dialogueFrame.SetActive(true);
    }

    IEnumerator WriteSentence()
    {
        char[] lettersOfSentence =  currentDialogue.sentences[currentSentenceIndex].ToCharArray();

        //foreach (var letra in lettersOfSentece)
        {
            
        }
        yield return new WaitForSeconds(currentDialogue.timeBetweenLetters);
    }

    void CompleteSentence()
    {
        dailogueText.text = currentDialogue.sentences[currentSentenceIndex];

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
        }
        else
        {
            CompleteSentence();
        }
    }

    void EndDialogue()
    {
        dialogueFrame?.SetActive(false);
        currentSentenceIndex = 0;
        writting = false;
        currentDialogue = null;
        Time.timeScale = 1;
    }
}
