using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour {
    public GameController gc;
    public GameObject backgroundgroup;
    public GameObject cow;
    //public float thisx;

    private float speed;
    private SpriteRenderer background;
    public float width;
    private Animator cowAnim;
	// Use this for initialization
	void Start () {
        cowAnim = cow.GetComponent<Animator>();
        background = GetComponent<SpriteRenderer>();
        width = background.bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {
        //thisx = speed;
        speed = gc.speed;
		if (transform.position.x >= width)
        {
            GameObject temp = Instantiate(gameObject, backgroundgroup.transform);
            temp.transform.position = new Vector3(temp.transform.position.x - 2 * width, temp.transform.position.y, temp.transform.position.z);
            Destroy(gameObject);
        }
        if (cowAnim.GetCurrentAnimatorStateInfo(0).IsName("Walking"))
        {
            transform.position = Vector3.Lerp(transform.position,
                new Vector3(transform.position.x + 2 * speed, transform.position.y, transform.position.z), Time.deltaTime);
        }
	}
}
