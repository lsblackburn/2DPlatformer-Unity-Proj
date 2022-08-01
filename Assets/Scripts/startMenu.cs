using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{

    public GameObject ObstacleMode;
    public GameObject StartMenu;
    
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        UnityEngine.Debug.Log("Application Quit");
        Application.Quit();
    }

    public void ObstacleCourseMap()
    {
        ObstacleMode.SetActive(true);
        StartMenu.SetActive(false);
    }

    public void BackButton()
    {
        ObstacleMode.SetActive(false);
        StartMenu.SetActive(true);
    }

}
