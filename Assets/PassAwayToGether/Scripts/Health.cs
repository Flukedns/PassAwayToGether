using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private PlayerController health;
    [SerializeField] private GameObject[] Hearts;
    private int HP;
    void Start()
    {
        
    }

    private void Update()
    {
        HP = health.hp;
        SetHP();
    }

    public void SetHP()
    {


        if (HP == 0 )
        {
            Hearts[0].SetActive(false);
            Hearts[1].SetActive(false);
            Hearts[2].SetActive(false);
            Hearts[3].SetActive(false);
            Hearts[4].SetActive(false);
        }
        if (HP == 1)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(false);
            Hearts[2].SetActive(false);
            Hearts[3].SetActive(false);
            Hearts[4].SetActive(false);
        }
        else if (HP == 2)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(true);
            Hearts[2].SetActive(false);
            Hearts[3].SetActive(false);
            Hearts[4].SetActive(false);
        }
        else if (HP == 3)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(true);
            Hearts[2].SetActive(true);
            Hearts[3].SetActive(false);
            Hearts[4].SetActive(false);
        }
        else if (HP == 4)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(true);
            Hearts[2].SetActive(true);
            Hearts[3].SetActive(true);
            Hearts[4].SetActive(false);
        }
        else if (HP == 5)
        {
            Hearts[0].SetActive(true);
            Hearts[1].SetActive(true);
            Hearts[2].SetActive(true);
            Hearts[3].SetActive(true);
            Hearts[4].SetActive(true);
        }
    }
    public void AddHP(int heal)
    {
        //HP += heal;
        SetHP();
    }
    

   
}
