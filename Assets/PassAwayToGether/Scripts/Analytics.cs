using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Random = System.Random;

public class Analytics : MonoBehaviour
{
    private static Analytics instance;
    public static Analytics Instance;
    private int playerActive = 1;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Instance = instance;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Initialize();
        PlayerCount(playerActive);
        TimeAlive();
        //WeaponUse("Mosquito Swatter");
        WeaponUse("Slipper");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private async void Initialize()
    {
        await UnityServices.InitializeAsync();
        AnalyticsService.Instance.StartDataCollection();
    }

    public void PlayerCount(int playerCount)
    {
        CustomEvent playerCount01 = new CustomEvent("PlayerCount")
        {
            { "PlayerCount", playerCount }
        };
        AnalyticsService.Instance.RecordEvent(playerCount01);
        Debug.Log("PlayerCount: " + playerCount);
    }

    public void WeaponUse(string weaponName)
    {
        CustomEvent weaponName01 = new CustomEvent("WeaponName")
        {
            {"WeaponName", weaponName}
        };
        AnalyticsService.Instance.RecordEvent(weaponName01);
        Debug.Log("Weapon:" + weaponName);
    }

    public void TimeAlive()
    {
        Random random = new Random();
        float minutes = random.Next(1, 61);
        CustomEvent timeAlive01 = new CustomEvent("TimePlayerAlive")
        {
            { "TimeAlive", minutes }
        };
        AnalyticsService.Instance.RecordEvent(timeAlive01);
        Debug.Log("TimePlayerAlive: " + minutes);
    }
    
}
