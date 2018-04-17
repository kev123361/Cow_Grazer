using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrassMove : MonoBehaviour {

    public GameObject slider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -2f)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x + .6f, transform.position.y), Time.deltaTime);
        } else
        {
            slider.SetActive(true);
        }
	}
}
