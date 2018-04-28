using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnContact : MonoBehaviour {

	public GameController gc;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("INTERACTING");
		//if (other.tag == "projectile") {
		//	gc.increaseMoney ();
		//}
		Destroy (other.gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
