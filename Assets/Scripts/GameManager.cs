//Zach Rhodes | 4/25/2024 | Game Manager Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

    //Singleton Initiation
=======
>>>>>>> parent of d09368e (ResolvingMerge)
=======
>>>>>>> parent of d09368e (ResolvingMerge)
=======
>>>>>>> parent of d09368e (ResolvingMerge)
=======
>>>>>>> parent of d09368e (ResolvingMerge)
=======
>>>>>>> parent of d09368e (ResolvingMerge)
    //Singleton Initiation

    public float maxHealth;
    public float currentHealth;
    public float force;
    public float armor;
    public float fortitude;

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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD



    public void InitiateFight()
=======
    // Start is called before the first frame update
    void Start()
>>>>>>> parent of d09368e (ResolvingMerge)
=======
    // Start is called before the first frame update
    void Start()
>>>>>>> parent of d09368e (ResolvingMerge)
=======
    // Start is called before the first frame update
    void Start()
>>>>>>> parent of d09368e (ResolvingMerge)
=======
    // Start is called before the first frame update
    void Start()
>>>>>>> parent of d09368e (ResolvingMerge)
=======
    // Start is called before the first frame update
    void Start()
>>>>>>> parent of d09368e (ResolvingMerge)
    {
        
    }
=======
>>>>>>> Fixing-stuff


    public void InitiateFight()
    {
        Debug.Log("Fight Started!");
        SceneManager.LoadScene("BattleStage");
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> parent of d09368e (ResolvingMerge)
=======
>>>>>>> parent of d09368e (ResolvingMerge)
=======
>>>>>>> parent of d09368e (ResolvingMerge)
=======
>>>>>>> parent of d09368e (ResolvingMerge)
=======
>>>>>>> parent of d09368e (ResolvingMerge)
  
}
