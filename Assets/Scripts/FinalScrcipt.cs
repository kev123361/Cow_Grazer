using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScrcipt : MonoBehaviour {
    public bool zoom;
    public AudioClip vacuum;

    private AudioSource asource;
	// Use this for initialization
	void Start () {
        zoom = false;
        StartCoroutine( StartScene());
        asource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (zoom)
        {
            this.transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z);
        }
	}

    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(5f);
        zoom = true;
        asource.PlayOneShot(vacuum);
        yield return new WaitForSeconds(2f);
        Application.Quit();
    }

    
}
