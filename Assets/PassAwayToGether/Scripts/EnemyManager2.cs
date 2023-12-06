using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour
{
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKill;
    
    public int health;
    private Animator anim;
    private GameManager gameManager;

    private void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("GameController");
        if (go != null)
        {
            gameManager = go.GetComponent<GameManager>();
        }
        anim = GetComponent<Animator>();
    }

    /*void OnTriggerEnter(Collider damage)
    {
        if (damage.gameObject.tag == "TakenDamage")
        {
            health -= 1;
            SoundManager.instance.Play(SoundManager.SoundName.hit);
            if (health <= 0)
            {
                anim.SetBool("IsDead", true);
                gameManager.GetScore();
                Destroy(gameObject,1f);
            }
        }
        
    }*/

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "TakenDamage")
        {
            health -= 1;
            SoundManager.instance.Play(SoundManager.SoundName.hit);
            if (health <= 0)
            {
                anim.SetBool("IsDead", true);
                gameManager.GetScore();
                //Destroy(gameObject,1f);
                DestroyEnemy();
            }
        }
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
        if (OnEnemyKill != null)
        {
            OnEnemyKill();
        }
    }
}
