using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnContact : MonoBehaviour {

	public GameController gc;
	public GameObject tmp;
	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log (other.gameObject);
		if (other.tag == "skyObject") {
			gc.increaseSkyMoney (checkPrice(other.gameObject));
		}
		Destroy (other.gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}

	private int checkPrice(GameObject g) {
		if (g.GetComponent<SpriteRenderer> ().sprite.name == "bird_Testing") {
			return 100;
		} else if (g.GetComponent<SpriteRenderer> ().sprite.name == "plane_Testing") {
			return 150;
		} else if (g.GetComponent<SpriteRenderer> ().sprite.name == "duckHunt_Testing") {
			return 200;
		} else if (g.GetComponent<SpriteRenderer> ().sprite.name == "ufo_Testing") {
			return 250;
		}else if(g.GetComponent<SpriteRenderer> ().sprite.name == "grass placeholder") {
			return 1000;
		}
		return 0;
	}
}
