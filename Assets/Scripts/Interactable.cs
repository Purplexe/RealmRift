//Zach Rhodes | 4/25/2024 | NPC Starting Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialoguePanel;
    public GameObject dialogueSymbol;
    public bool fightable;
  

    private bool playerClose;

    //If player is close and pressing E
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
    //Starting Dialogue Script
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, fightable);
    }

    //Each method checking whether or not the player is close
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
