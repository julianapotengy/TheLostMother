﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private PlayerScript player;
    
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        player.canJump = true;
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        player.canJump = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        player.canJump = false;
    }
}
