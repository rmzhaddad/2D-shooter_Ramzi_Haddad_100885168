using UnityEngine;
using System.Collections;


public class EnemyCollider : MonoBehaviour {





	void OnTriggerEnter2D(Collider2D other)
	{
		// to reduce life when collide with with the wall
		if (other.gameObject.tag == "Wall") {
			Player.Instance.Health -= 5; 
			if (Player.Instance.Health <= 0)
				Destroy (gameObject);
		}

	}

		void OnCollisionEnter2D(Collision2D other)
		{


		// to destroy the bullet object when collilde with enemy
		if(other.gameObject.tag=="Bullet"){
	
			Destroy (other.gameObject);

		}



		}


	


}
