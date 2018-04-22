using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCost : MonoBehaviour {
    public GameController gc;
    public ShopController sc;

    private Text text;
	// Use this for initialization
	void Start () {
        text = GetComponentInChildren<Text>();
	}

    // Update is called once per frame
    void Update() {
        switch (gameObject.name) {
            case ("EatingRateButton"):
                text.text = "$" + sc.upgradeCosts[gc.eatingRate];
                break;
            case ("HormonesButton"):
                text.text = "$" + sc.upgradeCosts[gc.hormones];
                break;
            case ("EquipmentButton"):
                text.text = "$" + sc.upgradeCosts[gc.equipment];
                break;
            case ("FieldButton"):
                text.text = "$" + sc.upgradeCosts[gc.field];
                break;
            case ("SpotsButton"):
                text.text = "$" + sc.upgradeCosts[gc.spots];
                break;
        }
	}
}
