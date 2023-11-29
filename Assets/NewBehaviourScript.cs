using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject enemyPrefab;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnNewEnemy();
    }

    void SpawnNewEnemy()
    {

        //if(OVRInput.GetDown(OVRInput.RawButton.))

        Instantiate(enemyPrefab, spawnPoint[0].transform.position, Quaternion.identity);

    }
}
