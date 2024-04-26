using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialoguePanel;
    public GameObject dialogueSymbol;

    private bool playerClose;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && playerClose)
        {
            dialoguePanel.SetActive(true);
            TriggerDialogue();
            
        }

        if(playerClose)
            dialogueSymbol.SetActive(true);
        else
            dialogueSymbol.SetActive(false);
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            playerClose = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            playerClose = false;
    }


}
