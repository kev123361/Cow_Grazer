using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddMoney : MonoBehaviour {

    private Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position,
            new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), Time.deltaTime);
        Color textColor = text.color;
        textColor.a -= 1f * Time.deltaTime;
        text.color = textColor;
    }
}
