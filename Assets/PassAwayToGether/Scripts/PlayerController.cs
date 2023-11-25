using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent agent;
    private int hp;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        hp = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0)
        {
            IsDead();
        }
        
    }

    void OnTriggerEnter(Collider damage)
    {
        if (damage.gameObject.tag == "TakeDamage")
        {
            hp = hp -1;
        }
    }

    void IsDead()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
