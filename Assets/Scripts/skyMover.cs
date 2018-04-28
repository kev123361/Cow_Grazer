using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyMover : MonoBehaviour {

	public float MoveSpeed = 0;

	public float frequency = 0;  // Speed of sine movement
	public float magnitude = 0;   // Size of sine movement
	private Vector3 axis;

	private Vector3 pos;

	void Start () {
		pos = transform.position;
		//DestroyObject(gameObject, 1.0f);
		axis = transform.up;  // May or may not be the axis you want

	}

	void Update () {
		pos += transform.right * Time.deltaTime * MoveSpeed;
		transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;
	}
}
