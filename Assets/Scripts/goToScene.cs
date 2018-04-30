using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goToScene : MonoBehaviour {
    public GameController gc;
    public void goToGame(string name)
    {
        if (gc.totalUpgradeLevel == 5 && SceneManager.GetActiveScene().name == "Market")
        {
            SceneManager.LoadScene("FinalLevel");
        }
        else { 
            Debug.Log("You have clicked the button");
            SceneManager.LoadScene(name);
        }
	}

	// Update is called once per frame
	void Update () {
		
	}
}
