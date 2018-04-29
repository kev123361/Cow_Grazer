using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyDead : MonoBehaviour {

	public int amount;

	private float MoveSpeed = 2;

	private float frequency = 5;  // Speed of sine movement
	private float magnitude = 0.5f;   // Size of sine movement
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
