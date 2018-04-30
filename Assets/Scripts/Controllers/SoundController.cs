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
	public AudioClip UFOAudio;

	public string currentSoundToPlay;

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
				currentSoundToPlay = "chomp";
				chewing = true;
			} else {
				if (gc.eatingRate <= 2) {
					currentSoundToPlay = "chew";
				} else if (gc.eatingRate < 4) {
					currentSoundToPlay = "slurp";
				} else {
					currentSoundToPlay = "bigSuck";
				}
			}
		} else {
			currentSoundToPlay = "noSound";
			chewing = false;
		}

		foreach (Transform child in transform) {
			if (child.gameObject.name == currentSoundToPlay) {
				child.gameObject.SetActive (true);
			} else {
				child.gameObject.SetActive (false);
			}
		}
	}
		/*if (cowAnim.GetCurrentAnimatorStateInfo (0).IsName ("Eating")) {
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
		//StartCoroutine(doSound ());*/
	//}

}
