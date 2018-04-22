using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class testButton : MonoBehaviour {

	public void goToGame() {
		Debug.Log ("You have clicked the button");
		SceneManager.LoadScene("BasicLevel");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
