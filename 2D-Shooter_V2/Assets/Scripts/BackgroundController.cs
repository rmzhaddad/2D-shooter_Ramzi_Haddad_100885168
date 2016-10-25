﻿using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour
{


	[SerializeField]
	private float speed;

	private Transform BackgroundTransform;
	private Vector2 BackgroundPosition;
	private float PlayerInput_Horizantal;
	private float PlayerInput_Vertical;

	// Use this for initialization
	void Start ()
	{
		BackgroundTransform = gameObject.GetComponent<Transform> ();
		BackgroundPosition = BackgroundTransform.position;
	}
	
	// Update is called once per tick
	void FixedUpdate ()
	{
		//this code is to move the background based on the movement of the player
		PlayerInput_Horizantal = Input.GetAxis ("Horizontal");
		PlayerInput_Vertical = Input.GetAxis ("Vertical");
		if (PlayerInput_Horizantal > 0) {
			BackgroundPosition += new Vector2 (speed, 0);
		}
		if (PlayerInput_Horizantal < 0) {
			BackgroundPosition -= new Vector2 (speed, 0);
		}
		if (PlayerInput_Vertical > 0) {
			BackgroundPosition += new Vector2 (0, speed);
		}
		if (PlayerInput_Vertical < 0) {
			BackgroundPosition -= new Vector2 (0, speed);
		}

		checkbounds ();
		BackgroundTransform.position = BackgroundPosition;

	}

	public void checkbounds ()
	{
		if (BackgroundPosition.x < -20f) {
			BackgroundPosition.x = -20f;
			
		}
		if (BackgroundPosition.x >20f) {
			BackgroundPosition.x = 20f;

		}
		if (BackgroundPosition.y >8f) {
			BackgroundPosition.y =8f;

		}

		if (BackgroundPosition.y <-8f) {
			BackgroundPosition.y =-8f;

		}

	}


}
