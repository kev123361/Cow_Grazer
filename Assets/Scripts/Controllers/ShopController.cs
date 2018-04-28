﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour {
    public GameController gc;
    public Text moneyCount;

    public int[] upgradeCosts = { 100, 200, 500, 750, 1000 };
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moneyCount.text = "$" + gc.money.ToString();
	}

    public void Purchase(string upgrade)
    {
        if (gc.totalUpgradeLevel < 5)
        {
            switch (upgrade)
            {
                case ("Eating Rate"):
                    if (gc.money >= upgradeCosts[gc.eatingRate] && gc.eatingRate <= gc.totalUpgradeLevel)
                    {
                        gc.money -= upgradeCosts[gc.eatingRate];
                        gc.eatingRate += 1;
                    }
                    break;
                case ("Hormones"):
                    if (gc.money >= upgradeCosts[gc.hormones] && gc.hormones <= gc.totalUpgradeLevel)
                    {
                        gc.money -= upgradeCosts[gc.hormones];
                        gc.hormones += 1;
                    }
                    break;
                case ("Equipment"):
                    if (gc.money >= upgradeCosts[gc.equipment] && gc.equipment <= gc.totalUpgradeLevel)
                    {
                        gc.money -= upgradeCosts[gc.equipment];
                        gc.equipment += 1;
                    }
                    break;
                case ("Field"):
                    if (gc.money >= upgradeCosts[gc.field] && gc.field <= gc.totalUpgradeLevel)
                    {
                        gc.money -= upgradeCosts[gc.field];
                        gc.field += 1;
                    }
                    break;
                case ("Spots"):
                    if (gc.money >= upgradeCosts[gc.spots] && gc.spots <= gc.totalUpgradeLevel)
                    {
                        gc.money -= upgradeCosts[gc.spots];
                        gc.spots += 1;
                    }
                    break;
            }
        }
    }
}
