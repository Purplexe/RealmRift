using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Base class setup, deriving from Mono and Interactable class. 
public abstract class NPCManager : MonoBehaviour, Interactable
{
    // Initializing players transform.
    private Transform _playerTransform;
    //Initializing NPC Interact sprite. 
    [SerializeField] private SpriteRenderer _interactSpr;

    private void Start()
    {
        // Filling player transform.
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        //If e was pressed and player is within distance? 
       if(Keyboard.current.eKey.wasPressedThisFrame && IsWithinDistance())
        {
            // Interact!
            Interact();
        }
       // if NPC is active and is not within the player distance,
        if (_interactSpr.gameObject.activeSelf && !IsWithinDistance())
        {
            // Turn off that sprite!
            _interactSpr.gameObject.SetActive(false);
        }
        // if NPC is within distance
        else if (!_interactSpr.gameObject.activeSelf && IsWithinDistance() )
        {
            // Turn on that sprite!
            _interactSpr.gameObject.SetActive(true);
        }

    }
    public abstract void Interact();
    

    private bool IsWithinDistance()
    {
        // If players distance to 
        if(Vector2.Distance(_playerTransform.position, transform.position) < 5f)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

}
