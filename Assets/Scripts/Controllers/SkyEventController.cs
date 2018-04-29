using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyEventController : MonoBehaviour {

	public float timer;
	public float timeToSpawn;
	private bool resetTimer;

	public GameController gc;

	public GameObject bird;
	public GameObject plane;
	public GameObject duckHunt;
	public GameObject ufo;
	public GameObject bird2;
	public GameObject tmp;

	public Vector2 spawnPosition;
	public GameObject flyingObject;

	private float maxY = 4.0f;
	private float minY = 1.0f;

	public float debug;

	// Use this for initialization
	void Start () {
		resetTimer = true;
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
			spawnObject ();
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

	void pickObject() {
		
		float sprite = Random.Range (0.0f, 1.0f);
		if (sprite <= .35f) {
			tmp = bird;
		} else if (sprite <= .70f) {
			tmp = bird2;
		} else if (sprite <= .90f) {
			tmp = plane;
		} else if (sprite <= .95f) {
			tmp = duckHunt;
		} else {
			tmp = ufo;
		}
	}

    void spawnObject()
    {
		pickObject ();
		GameObject temp = Instantiate(tmp, calculatePos(), flyingObject.transform.rotation);
    }
}
