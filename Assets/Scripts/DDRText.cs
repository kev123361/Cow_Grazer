using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDRText : MonoBehaviour {

    // Use this for initialization
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
        transform.position = Vector3.Lerp(transform.position, 
            new Vector3(transform.position.x, transform.position.y + .2f, transform.position.z), Time.deltaTime);
        Color spriteCol = sprite.color;
        spriteCol.a -= .03f;
        sprite.color = spriteCol;
	}
}
