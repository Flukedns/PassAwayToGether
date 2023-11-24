using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseItem : MonoBehaviour
{
    [SerializeField] private GameObject ItemScreen;
    [SerializeField] private Health health;
    [SerializeField] private SpriteRenderer slipperCard;
    [SerializeField] private SpriteRenderer swatterCard;
    
    [SerializeField] private Button slipperButton;
    [SerializeField] private Button swatterButton;
    public void EnergyDrink()
    {
        health.AddHP(1);
        ItemScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void Slipper()
    {
        slipperButton.interactable = false;
        ItemScreen.SetActive(false);
        slipperCard.color= Color.gray;
        Time.timeScale = 1;
    }

    public void Swatter()
    {
        swatterButton.interactable = false;
        ItemScreen.SetActive(false);
        swatterCard.color = Color.gray;
        Time.timeScale = 1;
    }
    
}
