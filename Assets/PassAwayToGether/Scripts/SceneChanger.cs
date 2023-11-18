using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToGamePlay()
    {   
        //Debug.Log("GamePlay");
        SceneManager.LoadScene("GamePlay");
    }

    public void ChangeToDialog()
    {   
        //Debug.Log("Dialog");
        SceneManager.LoadScene("Dialog");
    }

    public void ChangeToMenu()
    {   
        //Debug.Log("Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
