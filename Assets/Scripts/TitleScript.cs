//Zach Rhodes | 4/26/2024 | Title Card Script!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    //If start button pressed, start
    public void StartGame()
    {
        SceneManager.LoadScene("RealmRift");
    }
    //If Quit button pressed, quit
    public void QuitGame()
    {
        Application.Quit();
    }
}
