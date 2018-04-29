using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrassMove : MonoBehaviour {
	public GameController gc;
    public GameObject cow;

    public GameObject slider;
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = cow.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < 3.5f)
        {
			transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x + gc.speed * 2, transform.position.y), Time.deltaTime);
        } else
        {
            slider.SetActive(true);
            anim.SetBool("loweringhead", true);
        }
	}
}
