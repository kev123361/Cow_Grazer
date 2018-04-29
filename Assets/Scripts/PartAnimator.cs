using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartAnimator : MonoBehaviour {
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PassState(string state)
    {
        Debug.Log(state);
        if (state == "Walking" )
        {
            anim.ResetTrigger("headraise");
            anim.SetTrigger("doneeating");
           
        } else if (state == "Head Lowering")
        {
            anim.ResetTrigger("doneeating");
            anim.SetTrigger("headlower");
            
        } else if (state == "Head Raising")
        {
            anim.ResetTrigger("eating");
            anim.SetTrigger("headraise");
            
        } else if (state == "Eating")
        {
            anim.ResetTrigger("headlower");
            anim.SetTrigger("eating");
            
        }
    }
}
