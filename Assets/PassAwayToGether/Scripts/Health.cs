using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{   
    [SerializeField] private GameObject[] Hearts;
    private int HP;
    public PlayerController2 playerController2;
   

    private void Start()
    {
        HP = playerController2.hp;
        SetHP(HP);
        
    }

    public void SetHP(int hp)
    {   
        Debug.Log(hp);
        if (hp == 0)
        {
            Hearts[0].SetActive(false);
            Hearts[1].SetActive(false);
            Hearts[2].SetActive(false);
            Hearts[3].SetActive(false);
            Hearts[4].SetActive(false);
        }
        if (hp == 1)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(false);
            Hearts[2].SetActive(false);
            Hearts[3].SetActive(false);
            Hearts[4].SetActive(false);
        }
        else if (hp == 2)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(true);
            Hearts[2].SetActive(false);
            Hearts[3].SetActive(false);
            Hearts[4].SetActive(false);
        }
        else if (hp == 3)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(true);
            Hearts[2].SetActive(true);
            Hearts[3].SetActive(false);
            Hearts[4].SetActive(false);
        }
        else if (hp == 4)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(true);
            Hearts[2].SetActive(true);
            Hearts[3].SetActive(true);
            Hearts[4].SetActive(false);
        }
        else if (hp == 5)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(true);
            Hearts[2].SetActive(true);
            Hearts[3].SetActive(true);
            Hearts[4].SetActive(true);
        }
    }
    
    
}
