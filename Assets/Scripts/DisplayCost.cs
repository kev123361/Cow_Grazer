using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCost : MonoBehaviour {
    public GameController gc;
    public ShopController sc;

    private Text text;
    private int upgradeLevel;
	// Use this for initialization
	void Start () {
        text = GetComponentInChildren<Text>();
	}

    // Update is called once per frame
    void Update() {
        upgradeLevel = gc.totalUpgradeLevel;
        switch (gameObject.name) {
            case ("EatingRateButton"):
                if (gc.eatingRate == 5)
                {
                    text.text = "Max";
                }
                else if (gc.eatingRate <= upgradeLevel)
                {
                    text.text = "$" + sc.upgradeCosts[gc.eatingRate];
                } else
                {
                    text.text = "Locked";
                }
                break;
            case ("HormonesButton"):
                if (gc.hormones == 5)
                {
                    text.text = "Max";
                }
                else if (gc.hormones <= upgradeLevel)
                {
                    text.text = "$" + sc.upgradeCosts[gc.hormones];
                }
                else
                {
                    text.text = "Locked";
                }
                break;
            case ("EquipmentButton"):
                if (gc.equipment == 5)
                {
                    text.text = "Max";
                }
                else if (gc.equipment <= upgradeLevel)
                {
                    text.text = "$" + sc.upgradeCosts[gc.equipment];
                }
                else
                {
                    text.text = "Locked";
                }
                break;
            case ("FieldButton"):
                if (gc.field == 5)
                {
                    text.text = "Max";
                }
                else if (gc.field <= upgradeLevel)
                {
                    text.text = "$" + sc.upgradeCosts[gc.field];
                } else
                {
                    text.text = "Locked";
                }
                break;
            case ("SpotsButton"):
                if (gc.spots == 5)
                {
                    text.text = "Max";
                }
                else if (gc.spots <= upgradeLevel)
                {
                    text.text = "$" + sc.upgradeCosts[gc.spots];
                } else
                {
                    text.text = "Locked";
                }
                break;
        }
	}
}
