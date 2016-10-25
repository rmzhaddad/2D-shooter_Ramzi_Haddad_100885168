using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour
{
	
	void OnTriggerEnter2D (Collider2D other)
	{
		
		if (other.gameObject.tag == "Enemy_Tank") {

			Debug.Log ("enemy");
			Player.Instance.Health -= 10;
			Player.Instance.points += 5;
		}

	}

}
