using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringJump : MonoBehaviour
{

public Animator animator;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) 
    {
           animator.SetTrigger("BounceCol"); 
    }

}
