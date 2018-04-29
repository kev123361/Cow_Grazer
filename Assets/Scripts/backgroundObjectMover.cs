using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundObjectMover : MonoBehaviour {
	public GameController gc;
	public GameObject cow;
	//public float thisx;

	private float speed;
	private SpriteRenderer background;
	public float width;
	private Animator cowAnim;
	private bool init;
	void Start () {
		init = true;
	}

	// Update is called once per frame
	void Update () {
		if (init) {
			cowAnim = cow.GetComponent<Animator>();
			background = GetComponent<SpriteRenderer>();
			width = background.bounds.size.x;
			init = false;
		}
		//thisx = speed;
		speed = gc.speed;
		if (transform.position.x >= width)
		{
			Destroy(gameObject);
		}
		if (cowAnim.GetCurrentAnimatorStateInfo(0).IsName("Walking"))
		{
			transform.position = Vector3.Lerp(transform.position,
				new Vector3(transform.position.x + 2 * speed, transform.position.y, transform.position.z), Time.deltaTime);
		}
	}
}
