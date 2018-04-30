using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyOnContact : MonoBehaviour {

	public GameController gc;
	public GameObject sc;
	public Canvas canvas;
	public GameObject tmp;
	public GameObject addMoneyText;
	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log (other.gameObject);
		int moneyAmount = 0;
		if (other.tag == "skyObject") {
			moneyAmount = checkPrice (other.gameObject);
			gc.increaseSkyMoney (moneyAmount);
		}
		other.gameObject.GetComponent<skyMover> ().enabled = false;
		other.gameObject.GetComponent<destroyByTime> ().lifeTime = 1.0f;
		other.gameObject.GetComponent<skyDead> ().enabled = true;
		float angle = -90;
		Quaternion r = Quaternion.AngleAxis(angle, Vector3.forward);
		other.gameObject.GetComponent<Transform> ().rotation = r;
		if (other.gameObject.name == "UFO(Clone)") {
			other.gameObject.GetComponent<AudioSource> ().enabled = false;
			other.gameObject.GetComponent<AudioSource> ().clip = gc.UFOAudio;
			//other.gameObject.GetComponent<AudioSource> ().enabled = true;
		}
		other.gameObject.GetComponent<AudioSource> ().enabled = true;

		GameObject moneyText = Instantiate(addMoneyText, canvas.transform);
		moneyText.GetComponent<Text>().text = "$" + moneyAmount;
		//Destroy (other.gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}

	private int checkPrice(GameObject g) {
		if (g.name == "Bird1(Clone)") {
			return 50;
		} else if (g.name == "Bird2(Clone)") {
			return 50;
		} else if (g.name == "Plane(Clone)") {
			return 100;
		} else if (g.name == "DuckHunt(Clone)") {
			return 500;
		}else if(g.name == "UFO(Clone)") {
			return 500;
		}
		return 0;
	}
}
