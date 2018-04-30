using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

	public float timer;
	public float timeToSpawn;
	private bool resetTimer;

	public GameController gc;
	public GameObject cow;
	private Animator cowAnim;

	public bool chew;

	// Use this for initialization
	void Start () {
		cowAnim = cow.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cowAnim.GetCurrentAnimatorStateInfo (0).IsName ("Eating")) {
			if (!chew) {
				GetComponent<AudioSource> ().enabled = true;
				chew = true;
			} else {
				GetComponent<AudioSource> ().enabled = true;
			}
		} else {
			GetComponent<AudioSource> ().enabled = false;
		}
	}
}
