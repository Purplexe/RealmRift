using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Update is called once per frame
    void Update()
    {
        
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
