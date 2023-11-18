using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScene : MonoBehaviour
{   
    [SerializeField] private GameObject[] images;
    [SerializeField] private GameObject nextButton;
    [SerializeField] private GameObject playButton;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        images[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextImage()
    {   
        if (index != images.Length - 1)
        {   
            
            index++;
            Debug.Log(index);
            images[index-1].SetActive(false);
            images[index].SetActive(true);
        }
        if(index==images.Length-1)
        {   
            nextButton.SetActive(false);
            playButton.SetActive(true);
        } 
    }
}
