//Zach Rhodes | 4/25/2024 | All things dialogue
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public GameObject dialogePanel;
    public bool isTalking;
    private bool isFightable;


    private Queue<string> sentences;
    

    //Initializing Sentences
    void Start()
    {
        sentences = new Queue<string>();
    }

    //Starting dialogue and seeing if NPC is fightable
    public void StartDialogue(Dialogue dialogue, bool fightable)
    {
        isFightable = fightable;
         isTalking = true;
        nameText.text = dialogue.name;
        sentences.Clear();
        
        
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    //Queue next sentence when F is pressed.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isTalking)
            DisplayNextSentence();
    }
    //Next Sentence
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0) 
        {
            EndDialogue();
            dialogePanel.SetActive(false);
            return;
        }
        Debug.Log("No problems here!");
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }
    //Ending Dialogue/Starting Combat
    void EndDialogue()
    {
        Debug.Log("All done");
        isTalking = false;
        if (isFightable)
            GameManager.instance.InitiateFight();

        

    }

}
