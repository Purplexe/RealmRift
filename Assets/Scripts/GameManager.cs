//Zach Rhodes | 4/25/2024 | Game Manager Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
<<<<<<< HEAD
    //Singleton Initiation
=======

    public float maxHealth;
    public float currentHealth;
    public float force;
    public float armor;
    public float fortitude;


<<<<<<< HEAD
>>>>>>> dc3bdec1b19708d8415ec4fda82c62a6c0be7360
=======
>>>>>>> dc3bdec1b19708d8415ec4fda82c62a6c0be7360
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
<<<<<<< HEAD
<<<<<<< HEAD


    public void InitiateFight()
    {
        Debug.Log("Fight Started!");
        SceneManager.LoadScene("BattleStage");
    }
=======
  
>>>>>>> dc3bdec1b19708d8415ec4fda82c62a6c0be7360
=======
  
>>>>>>> dc3bdec1b19708d8415ec4fda82c62a6c0be7360
}
