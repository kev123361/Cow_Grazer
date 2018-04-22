using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
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

	// Use this for initialization
	void Start () {
		totalMoney.text = "Money: $" + money.ToString();
		addMoney = 10;
	}
	
	// Update is called once per frame
	void Update () {
		totalMoney.text = "Money: $" + money.ToString();
	}

	public void increaseMoney() {
		money += addMoney;

	}

}