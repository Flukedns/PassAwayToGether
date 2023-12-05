using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;

    //[SerializeField] private GameObject LaserPoint;
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {   
            pauseScreen.SetActive(true);
            //LaserPoint.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {   
        pauseScreen.SetActive(false);
        //LaserPoint.SetActive(false);
        Time.timeScale = 1;
    }
}
