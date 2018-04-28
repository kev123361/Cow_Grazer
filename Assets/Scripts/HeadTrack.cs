using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrack : MonoBehaviour {

	public GameController gc; 

	public GameObject fb;
	public Transform head;

	public float timeToFire;
	public float lazerTimer;
	public bool isCharging;


	public GameObject lazer1;
	public GameObject lazer2;

	public GameObject lazerMain;
	public bool instantiate;

	// Use this for initialization
	void Start () {
		lazerMain = Instantiate (lazerMain, head.position, head.rotation);
		lazerMain.SetActive (false);
	}

	void TaskOnClick() {
		Debug.Log ("should instantiate thing wow");
		Instantiate (fb, head.position, head.rotation);
	}

	// Update is called once per frame
	void Update () {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if (gc.hormones == 3) {
			if (Input.GetMouseButtonDown (1)) {
				Debug.Log ("YOU JUST CLICKED THING");
				TaskOnClick ();
			}
		} else if (gc.hormones == 4) {
			if (Input.GetMouseButtonDown (1)) {
				if (isCharging) {
					resetLazer ();
				} else {
					charge ();
				}
			} else if (Input.GetMouseButton (1)) {
				lazerTimer += Time.deltaTime;
				if (isCharging && lazerTimer > timeToFire) {
					fireLazer ();
				}

			} else if (Input.GetMouseButtonUp (1)) {
				isCharging = false;
				GameObject everything;
				everything = GameObject.Find("smallLazer(Clone)");
				Destroy (everything);
			}
		} else if (gc.hormones == 5) {
			if (Input.GetMouseButtonDown (1)) {
				lazerMain.SetActive (true);
			} else if (Input.GetMouseButton (1)) {
				lazerMain.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			}else if (Input.GetMouseButtonUp (1)) {
				lazerMain.SetActive (false);
			}
		}
	}

	void resetLazer() {
		GameObject everything;
		everything = GameObject.Find("smallLazer(Clone)");
		Destroy (everything);
		isCharging = false;
	}

	void charge() {
		Instantiate (lazer1, head.position, head.rotation);

		lazerTimer = 0;
		isCharging = true;
	}

	void fireLazer () {
		Instantiate (lazer2, head.position, head.rotation);
		isCharging = false;
	}

}