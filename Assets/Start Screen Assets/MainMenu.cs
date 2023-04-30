using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ContinueGame() //Loads the most recently saved game.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads the next scene in the queue
    }

    public void NewGame() //Starts a new game
    {

    }

    public void LoadGame() //Takes the player to the Load Game submenu
    {

    }

    public void Options() //Takes the player to the Options Sugmenu
    {

    }

    public void QuitGame() //Quits the game
    {

    }
}
