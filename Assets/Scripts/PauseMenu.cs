using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public void resumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        // This resumes the game when the resume button is pressed
    }

    public void quitLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        // This quits the level when the quit button is pressed and takes the player back to the main menu
    }

    public void closeApplication()
    {
        Application.Quit();
        UnityEngine.Debug.Log("Application closed");
        // This quits the application when the quit button is pressed
    }
}
