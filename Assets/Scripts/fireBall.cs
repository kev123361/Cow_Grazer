using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBall : MonoBehaviour {

	public float speed;
	public Vector2 debug;

	// Use this for initialization
	void Start () {
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}

	// Update is called once per frame
	void Update () {
		debug = transform.forward;
		//transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x + speed, transform.position.y), Time.deltaTime);
		//rigidbody2d.AddForce(transform.up * boostSpeed * 10);
	}
}
