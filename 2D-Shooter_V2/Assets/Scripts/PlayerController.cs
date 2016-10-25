using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{


	[SerializeField]
	private float speed;

	private Transform Player_Transform;
	private Vector2 player_currentPosition;
	private float Player_input_horizontal;
	private float Player_input_Vertical;




	// Use this for initialization
	void Start ()
	{
		// this code is find the position of the player
		Player_Transform = gameObject.GetComponent<Transform> ();
		player_currentPosition = Player_Transform.position;
	}
	
	// Update is called once per tick
	void FixedUpdate ()
	{
		// this code is to configure the horizontal movement
		Player_input_horizontal = Input.GetAxis ("Horizontal");
		//movemenet to the right 
		if (Player_input_horizontal > 0) {
		
			player_currentPosition += new Vector2 (speed, 0);
		}
		// movement to the left
		if (Player_input_horizontal < 0) {

			player_currentPosition -= new Vector2 (speed, 0);
		}
		// this code is to configure the Vertical movement
		Player_input_Vertical = Input.GetAxis ("Vertical");
		//movemenet to the top
		if (Player_input_Vertical > 0) {

			player_currentPosition += new Vector2 (0, speed);
		}
		// movement to the buttom
		if (Player_input_Vertical < 0) {

			player_currentPosition -= new Vector2 (0, speed);
		}

		// this function is to hold the player in the scene 
		checkbounds ();
		Player_Transform.position = player_currentPosition;

	
	}

	private void checkbounds ()
	{
		//to restore if below the screen
		if (player_currentPosition.x < -28f) {
		
			player_currentPosition.x = -28f;
		}
		if (player_currentPosition.y < -17f) {

			player_currentPosition.y = -17f;
		}
		// to restore if above the screen 
		if (player_currentPosition.x >28f) {

			player_currentPosition.x = 28f;
		}
		if (player_currentPosition.y > 17f) {

			player_currentPosition.y = 17f;
		}



	}



}
