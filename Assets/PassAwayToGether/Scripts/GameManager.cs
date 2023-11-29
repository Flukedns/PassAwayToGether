using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Samples;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Timer t;
    public PlayerController Hp;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Win();
        GameOver();
    }

    void GameOver()
    {
        if (Hp.hp == 0)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    void Win()
    {
        if (t.toContinue == false)
        {
            
            winScreen.SetActive(true);
            Time.timeScale = 0;
            
        }
        
    }
}
