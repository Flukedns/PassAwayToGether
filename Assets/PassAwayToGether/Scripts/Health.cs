using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private PlayerController health;
    [SerializeField] private GameObject[] Hearts;
    public int HP;
    void Start()
    {
        HP = 5;
    }

    public void SetHP()
    {
        
        
        
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
        HP += heal;
        SetHP();
    }
    

   
}
