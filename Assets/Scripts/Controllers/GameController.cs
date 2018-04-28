using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public float timer;
	public Text totalMoney;

    public int money;
	public int addMoney;
    public float frequency;
    public float speed;

    //Public variables for upgrade levels
    public int eatingRate;
    public int hormones;
    public int equipment;
    public int field;
    public int spots;
    public int totalUpgradeLevel;

	// Use this for initialization
	void Start () {
        LoadPrefs();
		totalMoney.text = "Money: $" + money.ToString();
		addMoney = 10;
	}
	
	// Update is called once per frame
	void Update () {
		totalMoney.text = "Money: $" + money.ToString();

        CheckUpgradeLevel();
	}

	public void increaseMoney() {
		money += addMoney;

	}

    private void CheckUpgradeLevel()
    {
        if ((eatingRate + hormones + equipment + field + spots) / 5 > totalUpgradeLevel)
        {
            totalUpgradeLevel += 1;
        }
    }

    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Eating Rate", 0);
        PlayerPrefs.SetInt("Hormones", 0);
        PlayerPrefs.SetInt("Equipment", 0);
        PlayerPrefs.SetInt("Field", 0);
        PlayerPrefs.SetInt("Spots", 0);
        PlayerPrefs.SetInt("Total Upgrade Level", 0);
        PlayerPrefs.SetInt("Money", 0);
    }

    public void SavePrefs()
    {
        PlayerPrefs.SetInt("Eating Rate", eatingRate);
        PlayerPrefs.SetInt("Hormones", hormones);
        PlayerPrefs.SetInt("Equipment", equipment);
        PlayerPrefs.SetInt("Field", field);
        PlayerPrefs.SetInt("Spots", spots);
        PlayerPrefs.SetInt("Total Upgrade Level", totalUpgradeLevel);
        PlayerPrefs.SetInt("Money", money);
    }

    public void LoadPrefs()
    {
        eatingRate = PlayerPrefs.GetInt("Eating Rate");
        hormones = PlayerPrefs.GetInt("Hormones");
        equipment = PlayerPrefs.GetInt("Equipment");
        field = PlayerPrefs.GetInt("Field");
        spots = PlayerPrefs.GetInt("Spots");
        totalUpgradeLevel = PlayerPrefs.GetInt("Total Upgrade Level");
        money = PlayerPrefs.GetInt("Money");
    }
}