using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour
{
    [SerializeField] private GameObject candleLight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            candleLight.SetActive(true);
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            candleLight.SetActive(false);
        }
    }

    /*public void LitCandle()
    {
        candleLight.SetActive(true);
    }

    public void UnlitCandle()
    {
        candleLight.SetActive(false);
    }*/
}
