using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyEventController : MonoBehaviour {

	public GameController gc;

	public Sprite bird;
	public Sprite plane;
	public Sprite duckHunt;
	public Sprite ufo;
	public Sprite extra;
	public Sprite[] skyObjects;

	public int spriteNum;
	public Vector2 spawnPosition;
	public GameObject flyingObject;

	// Use this for initialization
	void Start () {
		skyObjects = new Sprite[] {
			bird, plane, duckHunt, ufo, extra
		};
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawnObject() {
		flyingObject.GetComponent<Sprite> = skyObjects [spriteNum];
		Instantiate (flyingObject, spawnPosition, flyingObject.transform.rotation);
	}
}
