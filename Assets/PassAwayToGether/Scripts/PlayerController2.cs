using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController2 : MonoBehaviour
{
    
    public int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void OnTriggerEnter(Collider damage)
    {
        if (damage.gameObject.tag == "TakenDamage")
        {
            StartCoroutine(DelayDamage());
            TakeDamage(1);
        }
    }

    void TakeDamage(int _damage)
    {
        hp -= _damage;
    }

    IEnumerator DelayDamage()
    {
        yield return new WaitForSeconds(0.75f);
    }
}
