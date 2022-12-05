using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public void LoadMenu()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("MainMenu");
    }
}
