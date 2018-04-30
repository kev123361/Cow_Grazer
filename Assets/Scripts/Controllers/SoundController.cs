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

	public AudioClip chew;
	public AudioClip chomp;

	public AudioClip d;

	public bool chewing;

	// Use this for initialization
	void Start () {
		cowAnim = cow.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cowAnim.GetCurrentAnimatorStateInfo (0).IsName ("Eating")) {
			if (!chewing) {
				GetComponent<AudioSource> ().clip = chomp;
				chewing = true;
			} else {
				GetComponent<AudioSource> ().clip = chew;
			}
		} else {
			GetComponent<AudioSource> ().clip = null;
			chewing = false;
		}
		d = GetComponent<AudioSource> ().clip;
		StartCoroutine(doSound ());
	}

}
