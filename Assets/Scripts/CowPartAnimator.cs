using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowPartAnimator : MonoBehaviour {
    private Animator cowAnim;
	// Use this for initialization
	void Start () {
        cowAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PassStateToChildren()
    {
        PartAnimator[] anims = GetComponentsInChildren<PartAnimator>();
        foreach (PartAnimator anim in anims)
        {
            if (cowAnim.GetCurrentAnimatorStateInfo(0).IsName("Walking"))
            {
                
                anim.PassState("Walking");
            } else if (cowAnim.GetCurrentAnimatorStateInfo(0).IsName("Head Lowering"))
            {
                anim.PassState("Head Lowering");
            }
            else if (cowAnim.GetCurrentAnimatorStateInfo(0).IsName("Eating"))
            {
                anim.PassState("Eating");
            }
            else if (cowAnim.GetCurrentAnimatorStateInfo(0).IsName("Head Raising"))
            {
                anim.PassState("Head Raising");
            }
        }
    }
}
