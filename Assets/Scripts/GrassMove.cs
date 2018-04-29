using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrassMove : MonoBehaviour {
	public GameController gc;
    public GameObject cow;

    public GameObject slider;
    private Animator anim;
    private string[] grassTypes = { "Grass", "TallGrass" };
	// Use this for initialization
	void Start () {
        anim = cow.GetComponent<Animator>();
        
    }
	
	// Update is called once per frame
	void Update () {
        CheckGrass();
		if (transform.position.x < 3.5f)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Walking")) 
                transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x + gc.speed * 2, transform.position.y), Time.deltaTime);
        } else
        {
            slider.SetActive(true);
            anim.SetBool("loweringhead", true);
        }
	}

    public void CheckGrass()
    {
        
        foreach (Transform child in transform)
        {
            if (child.gameObject.name == grassTypes[gc.field])
            {
                
                child.gameObject.SetActive(true);
            } else
            {
                child.gameObject.SetActive(false);
            }
        }
        
    }
}
