using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{


	[SerializeField]
	private float speed;

	public GameObject Bullet;//this is the bullet prefab
	public GameObject BulletPosition;
	public GameObject BulletAnimation;// to create the shoot animation
	public GameObject AnimationPosition;


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

		//this code is a part of the gameover process
		if(Player.Instance.Health<=0){
			Destroy (gameObject);
			
		}

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
		if(Input.GetKeyDown("space")){
			AudioSource BulletMusica = gameObject.GetComponent<AudioSource> ();
			BulletMusica.Play ();// to play the firing sound
			GameObject bullet = (GameObject)Instantiate (Bullet);//to creat the bullet 
			bullet.transform.position = BulletPosition.transform.position;//keep the bullet in the correct place
			GameObject Animate = (GameObject)Instantiate (BulletAnimation);//to creat the animation 
			Animate.transform.position = AnimationPosition.transform.position;//keep the animation in the correct place






		}


	
	
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
		if (player_currentPosition.x > 28f) {

			player_currentPosition.x = 28f;
		}
		if (player_currentPosition.y > 17f) {

			player_currentPosition.y = 17f;
		}



	}



}
