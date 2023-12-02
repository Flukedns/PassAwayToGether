using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager2 : MonoBehaviour
{
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKill;
    
    public int health;
    private Animator anim;
    

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider damage)
    {
        if (damage.gameObject.tag == "TakenDamage")
        {
            health -= 1;
        }

        if (health <= 0)
        {
            anim.SetBool("IsDead", true);
            Destroy(gameObject,2f);
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
