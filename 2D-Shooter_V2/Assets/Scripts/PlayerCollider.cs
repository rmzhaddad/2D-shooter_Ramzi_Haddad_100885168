using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour
{
	
	void OnTriggerEnter2D (Collider2D other)
	{
		// when the tank collide with tank
		if (other.gameObject.tag == "Enemy_Tank") {


			Player.Instance.Health -= 10;// health -10

		}

	}

}
