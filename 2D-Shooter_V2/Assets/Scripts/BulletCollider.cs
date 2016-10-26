using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour
{

	public GameObject Enemy;



	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Enemy_Tank") {

		}
	}
	void OnCollisionEnter2D(Collision2D other){
		{


			// to destroy enemy tank when colllide with bollet
			if (other.gameObject.tag == "Enemy_Tank") {
				Player.Instance.NumOfEnemy--;// to control the number of enemies on screen
				AudioSource TankDestroyed = gameObject.GetComponent<AudioSource> ();
				// to play the explosion sound
				Player.Instance.points += 10;
				TankDestroyed.Play ();
				Destroy (other.gameObject);

				// this code is create more enemy to repalce the dead ones
				if (Player.Instance.NumOfEnemy <= 0 && Player.Instance.Health>0 && Player.Instance.points <= 75) 
				{
					
					GameObject Enemy1 = (GameObject)Instantiate (Enemy);
					Player.Instance.NumOfEnemy++;


		
				}
				// to check the number of enemies on screen and instiate the target number
				if (  Player.Instance.NumOfEnemy <= 0 && Player.Instance.Health>0 && Player.Instance.points>75   ) 
				{

					GameObject Enemy1 = (GameObject)Instantiate (Enemy);

					GameObject Enemy2 = (GameObject)Instantiate (Enemy);
					Player.Instance.NumOfEnemy += 2;


				}
				// in case of one is not destroyed ( just reset when hit the wall)
				if (  Player.Instance.NumOfEnemy == 1 && Player.Instance.Health>0 && Player.Instance.points>75   ) 
				{

					//GameObject Enemy1 = (GameObject)Instantiate (Enemy);

					GameObject Enemy2 = (GameObject)Instantiate (Enemy);
					Player.Instance.NumOfEnemy += 1;


				}
				if (  Player.Instance.NumOfEnemy == 1 && Player.Instance.Health>0  && Player.Instance.points>200   ) 
				{

					GameObject Enemy1 = (GameObject)Instantiate (Enemy);

					GameObject Enemy2 = (GameObject)Instantiate (Enemy);
					Player.Instance.NumOfEnemy += 1;


				}
				if (  Player.Instance.NumOfEnemy == 2 &&Player.Instance.Health>0 && Player.Instance.points>200   ) 
				{

					//GameObject Enemy1 = (GameObject)Instantiate (Enemy);

					GameObject Enemy2 = (GameObject)Instantiate (Enemy);
					Player.Instance.NumOfEnemy += 1;


				}



			}
		
		}
	}
}