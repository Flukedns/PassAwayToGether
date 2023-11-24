using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {   
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {   
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
