using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Samples;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private int score;
    public Timer t;
    public PlayerController2 hp;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject UpgradeScreen;
    private int overCount = 0;
    private int winCount = 0;
    private int upgrade = 0;
    private float _timer;
    private int minutes;
    private int seconds;
    private string ti;
    void Start()
    {   
        score = 0;
        Time.timeScale = 1;
        SoundManager.instance.Play(SoundManager.SoundName.BGM);
        Analytics.Instance.WeaponUse("Mosquito Swatter");
        Analytics.Instance.WeaponUse("Slipper");
    }

   
    void Update()
    {
        if (t.toContinue == false)
        {   
            Win();
        }
        if (hp.hp == 0)
        {
            GameOver();
        }
        if (score% 5==0)
        {   
            if (score != 0)
            {   
                Upgrade();
            }
            
        }
    }

    void GameOver()
    {
        overCount += 1;
        if(overCount==1){
            SoundManager.instance.Play(SoundManager.SoundName.Lose);
            UpgradeScreen.SetActive(false);
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    void Upgrade()
    {
        upgrade += 1;
        if (upgrade == 1)
        {
            SoundManager.instance.Play(SoundManager.SoundName.upgrade);
            //Time.timeScale = 0;
            UpgradeScreen.SetActive(true);
            upgrade = 0;
        }
    }

    void Win()
    {
        winCount += 1;
        if (winCount==1)
        {
            SoundManager.instance.Play(SoundManager.SoundName.Win);
            UpgradeScreen.SetActive(false);
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    public void GetScore()
    {
        score += 1;
        if (score % 5 == 0)
        {
            UpgradeScreen.SetActive(true);
        }
    }
}
