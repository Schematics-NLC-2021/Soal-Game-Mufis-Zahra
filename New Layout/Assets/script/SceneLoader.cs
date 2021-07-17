using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    //if currentSceneIndex > Scene Index

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Submission()
    {
        SceneManager.LoadScene("Submit");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game Core");
        FindObjectOfType<Game_Status>().ResetGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
