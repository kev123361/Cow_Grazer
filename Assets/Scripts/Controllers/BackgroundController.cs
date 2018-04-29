using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

	public float timer;
	public float timeToSpawn;
	private bool resetTimer;

	public GameController gc;
	public GameObject cow;

	public GameObject testing;
	
	public GameObject toSpawn;

	private float speed;
	private SpriteRenderer background;
	public float width;
	private Animator cowAnim;
	private bool forground;
	private float scale;

	// Use this for initialization
	void Start () {
		cowAnim = cow.GetComponent<Animator>();
		resetTimer = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (resetTimer) {
			timeToSpawn = Random.Range (2.0f, 5.0f);
			timer = 0;
			resetTimer = false;
		}

		if (cowAnim.GetCurrentAnimatorStateInfo (0).IsName ("Walking")) {
			timer += Time.deltaTime;
		}

		if (timer > timeToSpawn) {
			spawnObject ();
			resetTimer = true;
		}
		//speed = gc.speed;
		//if (cowAnim.GetCurrentAnimatorStateInfo (0).IsName ("Walking")) {
		//	transform.position = Vector3.Lerp(transform.position,
		//		new Vector3(transform.position.x + 2 * speed, transform.position.y, transform.position.z), Time.deltaTime);
		//}
	}

	Vector2 calculatePos() {
		forground = false;
		float xPos = -15.0f;
		float yPos = -1.0f;
		scale = Random.Range (0.5f, 0.65f);
		if (Random.Range (0.0f, 1.0f) <= .5) {
			scale = Random.Range (0.75f, 1.0f);
			yPos = -2.5f;
			forground = true;
		}
		Vector2 pos = new Vector2 (xPos, yPos);
		return pos;
	}

	void pickObject() {
		float sprite = Random.Range (0.0f, 1.0f);
		toSpawn = testing;
	}

	void spawnObject() {
		pickObject ();
		GameObject temp = Instantiate (toSpawn, calculatePos (), toSpawn.transform.rotation);
		temp.GetComponent<backgroundObjectMover> ().gc = this.gc;
		temp.GetComponent<backgroundObjectMover> ().cow = this.cow;
		if (forground) {
			temp.GetComponent<SpriteRenderer> ().sortingLayerName = "Grass";
			temp.GetComponent<SpriteRenderer> ().sortingOrder = 6;
		}
		temp.GetComponent<Transform> ().localScale = temp.GetComponent<Transform> ().localScale * scale;
	}
}
