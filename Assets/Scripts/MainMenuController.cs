using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// to play with selected player you need to add this using
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject player;

    string playerTag = "Player";
=======
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
    public void PlayGame()
    {

        int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = selectedCharacter;
        SceneManager.LoadScene("Gameplay");
    }
<<<<<<< HEAD

    public void PlayGameBtn()
    {
        player = GameObject.FindGameObjectWithTag(playerTag);
       
        GameManager.instance.CharIndex = int.Parse(player.name);
        SceneManager.LoadScene("Gameplay");
    }
=======
>>>>>>> 16ceb060bebc87f489c60181eab25c69435cd255
}
