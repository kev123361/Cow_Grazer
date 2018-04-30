using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public AudioClip UFOAudio;

	public Text totalMoney;
    public GameObject udders;
    public GameObject frontlegs;
    public GameObject backlegs;
    public GameObject cow;
    public GameObject body;
    public GameObject head;

    public GameObject[] backgrounds;
    public GameObject secondhead;
    public GameObject secondneck;

    public int money;
	public int addMoney = 30;
    public float frequency;
    public float speed = 1f;

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
        if (SceneManager.GetActiveScene().name != "MainMenu")
        {
            //Debug.Log(SceneManager.GetActiveScene().name);
            GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().PlayMusic();
        }
    }
	
	// Update is called once per frame
	void Update () {
		totalMoney.text = "Money: $" + money.ToString();
        CheckUpgradeLevel();
        CheckUpgrades();
	}

	public int increaseMoney() {
		money += addMoney;
        return addMoney;
	}

	public void increaseSkyMoney(int amount) {
		money += amount;
	}

    private void CheckUpgradeLevel()
    {
        if ((eatingRate + hormones + equipment + field + spots) / 5 > totalUpgradeLevel)
        {
            totalUpgradeLevel += 1;
        }
    }

    private void CheckUpgrades()
    {
        if (SceneManager.GetActiveScene().name == "BasicLevel") { 
            if (hormones == 1)
            {
                udders.GetComponent<Animator>().SetLayerWeight(1, 1);
            }
             else if (hormones == 2)
            {
                backlegs.GetComponent<Animator>().SetLayerWeight(1, 1);
                frontlegs.GetComponent<Animator>().SetLayerWeight(1, 1);
                cow.transform.position = new Vector3(cow.transform.position.x, -2.5f, cow.transform.position.z);
            }
            else if (hormones == 3)
            {
                secondhead.SetActive(true);
                secondneck.SetActive(true);
            }
            if (equipment == 3)
            {
                backlegs.GetComponent<Animator>().SetLayerWeight(2, 1);
                frontlegs.GetComponent<Animator>().SetLayerWeight(2, 1);
            }
            if (totalUpgradeLevel == 2)
            {
                backgrounds[0].SetActive(false);
                backgrounds[1].SetActive(true);
            } else if (totalUpgradeLevel == 4)
            {
                backgrounds[0].SetActive(false);
                backgrounds[1].SetActive(false);
                backgrounds[2].SetActive(true);
            }
            if (spots == 1)
            {
                body.GetComponent<Animator>().SetLayerWeight(1, 1);
            } else if (spots == 2)
            {
                body.GetComponent<Animator>().SetLayerWeight(2, 1);
            }
            if (eatingRate == 2)
            {
                head.GetComponent<Animator>().SetLayerWeight(1, 1);
            } else if (eatingRate == 3)
            {
                head.GetComponent<Animator>().SetLayerWeight(2, 1);
            } else if (eatingRate == 4)
            {
                head.GetComponent<Animator>().SetLayerWeight(3, 1);
            }
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
        PlayerPrefs.SetInt("Money", 50);
        PlayerPrefs.SetInt("Add Money", 30);
        PlayerPrefs.SetFloat("Speed", 1);
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
        PlayerPrefs.SetInt("Add Money", addMoney);
        PlayerPrefs.SetFloat("Speed", speed);
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
        addMoney = PlayerPrefs.GetInt("Add Money");
        speed = PlayerPrefs.GetFloat("Speed");
    }
}