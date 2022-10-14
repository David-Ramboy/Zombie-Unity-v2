using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
using UnityEngine.UI;

=======
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    // Create players Array so we can Choose what characters we will use
    [SerializeField]
    private GameObject[] characters;

<<<<<<< HEAD
    //[SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

=======
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
    public int _charIndex;
    public int CharIndex
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }

    private void Awake()
    {
<<<<<<< HEAD

=======
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // This is TO spawn char use events and delegates
    private void OnEnable()
    {
<<<<<<< HEAD

        SceneManager.sceneLoaded += OnLevelFinishedLoading;

=======
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
<<<<<<< HEAD

    }

=======
    }
    
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
    void OnLevelFinishedLoading(Scene scene,LoadSceneMode mode)
    {
        if(scene.name == "Gameplay")
        {
<<<<<<< HEAD

            Instantiate(characters[CharIndex]);

        }

    }
=======
            Instantiate(characters[CharIndex]);
        }
    }


>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
}   
