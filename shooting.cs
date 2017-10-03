﻿//Mike Fortin
//Player can only shoot left or right
//Bullet needs to rotate
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	public GameObject Bullet; 
	private Vector2 leftPositionFix;
	private float leftOffset = .05f;
	//public float shotDelay = 5f; 
	//private bool shotFired = false;
		
	private PlayerScript2 player;
	void Start () 
	{
		animator = GetComponent<Animator> ();
		player = FindObjectOfType<PlayerScript2> ();

	}

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Y) && player.ammo > 0)
		{   
			//animator.SetTrigger ("attack"); //We will need left, right, up, down attacking animations
			if (player.getDirectionString () == "l") {
				leftPositionFix.Set (transform.position.x - leftOffset, transform.position.y);
				Instantiate (Bullet, leftPositionFix,  new Quaternion(0, 0, 0, 0));
			} 
			else if (player.getDirectionString() == "r")
			{
				Instantiate (Bullet, transform.position, new Quaternion (0, 0, 0, 0));
			}
			player.ammo -= 1;
			//shotFired = true;

		}
	}

}
