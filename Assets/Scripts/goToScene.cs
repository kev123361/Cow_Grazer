using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goToScene : MonoBehaviour {

	public void goToGame(string name) {
		Debug.Log ("You have clicked the button");
		SceneManager.LoadScene(name);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
