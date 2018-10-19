﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        var hori = Input.GetAxis("Horizontal");

        run();
        jump();

        
    }

    void run()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("right pressed");
            anim.SetBool("running", true);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Debug.Log("right pressed");
            anim.SetBool("running", false);
        }
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !anim.GetBool("running"))
        {
            anim.SetTrigger("jump");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && anim.GetBool("running"))
        {
            anim.SetTrigger("runJump");
        }
    }
}
