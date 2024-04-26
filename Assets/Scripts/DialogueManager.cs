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
    


    void Start()
    {
        sentences = new Queue<string>();
    }

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isTalking)
            DisplayNextSentence();
    }
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
    void EndDialogue()
    {
        Debug.Log("All done");
        isTalking = false;
        if (isFightable)
            GameManager.instance.InitiateFight();

        

    }

}
