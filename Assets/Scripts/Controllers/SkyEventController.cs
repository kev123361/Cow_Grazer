using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyEventController : MonoBehaviour {

	public float timer;
	public float timeToSpawn;
	private bool resetTimer;

	public GameController gc;

	public Sprite bird;
	public Sprite plane;
	public Sprite duckHunt;
	public Sprite ufo;
	public Sprite extra;
	public Sprite[] skyObjects;

	public Vector2 spawnPosition;
	public GameObject flyingObject;

	private float maxY = 4.0f;
	private float minY = 1.0f;

	public float debug;

	// Use this for initialization
	void Start () {
		resetTimer = true;
		skyObjects = new Sprite[] {
			bird, plane, duckHunt, ufo, extra
		};
	}
	
	// Update is called once per frame
	void Update () {
		if (resetTimer) {
			timeToSpawn = Random.Range (2.0f, 10.0f);
			timer = 0;
			resetTimer = false;
		}
		timer += Time.deltaTime;
		if (timer > timeToSpawn) {
			spawnObject (pickObject ());
			resetTimer = true;
		}



		//if (Input.GetMouseButtonDown (1)) {
		//	Debug.Log ("Stuffs and Things");
		//	spawnObject ();
		//}
	}

	Vector2 calculatePos() {
		Vector2 pos = new Vector2 (-15.0f, Random.Range (minY, maxY));
		return pos;
	}

	int pickObject() {
		float sprite = Random.Range (0.0f, 1.0f);
		if (sprite <= .35f) {
			return 0; //Bird1
		} else if (sprite <= .70f) {
			return 4; //Bird2
		} else if (sprite <= .90f) {
			return 1; //Plane
		} else if (sprite <= .95f) {
			return 2; //DuckHunt
		} else {
			return 3; //UFO
		}
	}

<<<<<<< HEAD
	void spawnObject(int sprite) {
		flyingObject.GetComponent<SpriteRenderer> ().sprite = skyObjects [sprite];
		Instantiate (flyingObject, calculatePos(), flyingObject.transform.rotation);
	}
}
