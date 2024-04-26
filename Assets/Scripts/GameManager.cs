//Zach Rhodes | 4/25/2024 | Game Manager Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    //Singleton Initiation

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }



    public void InitiateFight()
    {
        Debug.Log("Fight Started!");
        SceneManager.LoadScene("BattleStage");
    }

}
