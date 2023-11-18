using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToGamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void ChangToDialog()
    {
        SceneManager.LoadScene("Dialog");
    }

    public void ChangeToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
