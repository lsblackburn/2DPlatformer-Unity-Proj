using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringAnimation : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetTrigger("BounceCol");
    }
}
