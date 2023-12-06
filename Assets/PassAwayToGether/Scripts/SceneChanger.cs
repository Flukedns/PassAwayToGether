using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToGamePlay()
    {   
        //Debug.Log("GamePlay");
        Time.timeScale = 1;
        SceneManager.LoadScene("GamePlay2");
    }

    public void ChangeToDialog()
    {   
        //Debug.Log("Dialog");
        Time.timeScale = 1;
        SceneManager.LoadScene("Dialog");
    }

    public void ChangeToMenu()
    {   
        //Debug.Log("Menu");
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
