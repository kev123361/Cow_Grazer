using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrack : MonoBehaviour {

	public GameObject fb;
	public Transform fbs;

	// Use this for initialization
	void Start () {
		
	}

	void TaskOnClick() {
		Debug.Log ("should instantiate thing wow");
		Instantiate (fb, fbs.position, fbs.rotation);
	}

	// Update is called once per frame
	void Update () {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("YOU JUST CLICKED THING");
			TaskOnClick ();
		}
	}
}