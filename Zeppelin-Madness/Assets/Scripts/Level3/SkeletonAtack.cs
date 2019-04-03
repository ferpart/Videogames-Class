using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAtack : MonoBehaviour {

    public Animator mAnimator;

    // Use this for initialization
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mAnimator.SetTrigger("attack");
    }
}
