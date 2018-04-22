using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicSlider : MonoBehaviour {
	public GameController gc;

    private Slider slider;
    public GameObject grass;
	// Use this for initialization
	void Start () {
        slider = this.GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.X))
        {
            slider.value += .1f;
        }
        if (slider.value == 1f)
        {
            slider.value = 0f;
            grass.transform.position = new Vector2(-13f, grass.transform.position.y);
            gameObject.SetActive(false);
			gc.increaseMoney();
        }
	}
}
