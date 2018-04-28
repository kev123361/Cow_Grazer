using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallMover : MonoBehaviour {


	public float speed;
	public Vector2 debug;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = transform.up * speed;
		Debug.Log (GetComponent<Rigidbody2D> ().velocity);
	}
}
