using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private Health health;
    public int hp=5;
    // Start is called before the first frame update
    void Start()
    {   
        GameObject go = GameObject.FindGameObjectWithTag("Health");
        if (go != null)
        {
            health = go.GetComponent<Health>();
        }
        hp = 5;
        health.SetHP(hp);
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
        health.SetHP(hp);
    }

    IEnumerator DelayDamage()
    {
        yield return new WaitForSeconds(0.75f);
    }

    public void AddHP()
    {
        hp += 1;
        Debug.Log("AddHP");
        if (hp > 5)
        {
            hp = 5;
        }
        health.SetHP(hp);
    }
}
