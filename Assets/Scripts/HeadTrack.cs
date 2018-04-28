using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrack : MonoBehaviour {

	public GameController gc;

	public float fireTimer;
	public float fireTime;
	public GameObject fb;
	public Transform head;

	public float timeToFire;
	public float lazerTimer;
	public bool isCharging;


	public GameObject lazer1;
	public GameObject lazerChargetmp;
	public GameObject lazer2;

	public GameObject lazerMain;
	public bool instantiate;

	// Use this for initialization
	void Start () {
		lazerMain = Instantiate (lazerMain, head.position, head.rotation);
		lazerMain.GetComponent<destroyOnContact> ().gc = this.gc;
		lazerMain.SetActive (false);
	}

	void fireFireBolt() {
		GameObject tmp = Instantiate (fb, head.position, head.rotation);
		tmp.GetComponent<destroyOnContact> ().gc = this.gc;
	}

	// Update is called once per frame
	void Update () {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if (gc.hormones == 3) {
			fireTimer += Time.deltaTime;
			if (Input.GetMouseButtonDown (1) && fireTimer > fireTime) {
				fireTimer = 0;
				fireFireBolt ();
			}
		} else if (gc.hormones == 4) {
			if (Input.GetMouseButtonDown (1)) {
				if (isCharging) {
					resetLazer ();
				} else {
					charge ();
				}
			} else if (Input.GetMouseButton (1)) {
				lazerChargetmp.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
				lazerTimer += Time.deltaTime;
				if (isCharging && lazerTimer > timeToFire) {
					fireLazer ();
					lazerChargetmp.SetActive (false);
				}

			} else if (Input.GetMouseButtonUp (1)) {
				lazerChargetmp.SetActive (true);
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
		lazerChargetmp = Instantiate (lazer1, head.position, head.rotation);

		lazerTimer = 0;
		isCharging = true;
	}

	void fireLazer () {
		GameObject tmp = Instantiate (lazer2, head.position, head.rotation);
		tmp.GetComponent<destroyOnContact> ().gc = this.gc;
		isCharging = false;
	}

}