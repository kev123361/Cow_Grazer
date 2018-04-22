using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrack : MonoBehaviour {

	public fireBall fb;

	// Use this for initialization
	void Start () {
		
	}

	void TaskOnClick() {
		Debug.Log ("YOU JUST CLICKED THING");
		Instantiate (fb, new Vector3(0, 0, 0), Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 180;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("YOU JUST CLICKED THING");
		}
	}
}
