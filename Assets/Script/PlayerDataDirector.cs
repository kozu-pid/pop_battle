﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerType
{
    None,
    Charactor1,
    Charactor2,
    Charactor3,
    Charactor4
}
public class PlayerDataDirector : Singleton<PlayerDataDirector> {

    private const int maxPlayerNumber = 4;
    public int MaxPlayerNumber
    {
        get
        {
            return maxPlayerNumber;
        }
    }

    public int participantsNumber()
    {
        int number = 0;
        for (int i = 0; i < PlayerTypes.Length; i++)
        {
            if (PlayerTypes[i] != PlayerType.None) number++;
        }
        return number;
    }

    public PlayerType[] PlayerTypes { get; private set; }

    public void PlayerTypeInit()
    {
        PlayerTypes = new PlayerType[MaxPlayerNumber];
        for(int i = 0;i < PlayerTypes.Length; i++)
        {
            PlayerTypes[i] = PlayerType.None;
        }
    }

    private new void Awake()
    {
        base.Awake();
        PlayerTypeInit();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        for (int i = 0; i < PlayerTypes.Length; i++)
        {
            Debug.Log("player" + (i + 1) + PlayerTypes[i]);
        }
        */
    }
}
