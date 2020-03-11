using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        SceneManager.LoadScene(1);
        SceneManager.UnloadScene(0);
        SceneManager.UnloadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
