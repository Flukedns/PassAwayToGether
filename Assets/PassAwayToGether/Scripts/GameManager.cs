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
    void Start()
    {   
        score = 0;
        Time.timeScale = 1;
        SoundManager.instance.Play(SoundManager.SoundName.BGM);
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
        if (score% 5==0&&score!=0)
        {
            UpgradeScreen.SetActive(true);
        }
    }

    void GameOver()
    {
        overCount += 1;
        if(overCount==1){
            SoundManager.instance.Play(SoundManager.SoundName.Lose);
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
        
        
        
    }

    void Win()
    {
        winCount += 1;
        if (winCount==1)
        {
            SoundManager.instance.Play(SoundManager.SoundName.Win);
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
