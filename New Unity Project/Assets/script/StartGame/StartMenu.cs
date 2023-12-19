using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGameEndless()
    {
        SceneManager.LoadSceneAsync("Endless");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Credit()
    {
        SceneManager.LoadSceneAsync("Credit");
    }

}
