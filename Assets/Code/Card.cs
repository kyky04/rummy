﻿using UnityEngine;
using System.Collections;

public class Card {
    public enum SUITS { CLUBS, DIAMONDS, HEARTS, SPADES };
    public SUITS suit {get; private set;}
    public int value { get; private set; }
    public int points { get; private set; }
    public int spriteNumber { get; private set; }
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void setSuit(SUITS newSuit)
    {
        this.suit = newSuit;
    }
    
    public void setValue(int newValue)
    {
        if (2 <= newValue && newValue <= 14)
        {
            this.value = newValue;
            _setPoints(newValue);
        }
        else
            throw new UnityException("ERROR: card set to illegal value");
        
    }

    public void calculateSpriteNumber()
    {
        spriteNumber = 4 * this.value + (int)this.suit - 8;
    }

    public void setSpriteNumber(int spriteNumber)
    {
        if (spriteNumber < 0 || spriteNumber > 62)
            throw new UnityException("card sprite set to out of range sprite number");
        this.spriteNumber = spriteNumber;
    }

    private void _setPoints(int value)
    {
        if (value == 2)
            this.points = 20;
        else if (3 <= value && value <= 9)
            this.points = 5;
        else if (10 <= value && value <= 13)
            this.points = 10;
        else
            this.points = 15;
    }

}
