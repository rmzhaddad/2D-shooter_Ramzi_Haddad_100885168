using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		
		if(other.gameObject.tag=="Wall"){
			Debug.Log ("it works");
			Player.Instance.Health -= 5; 
		}
	}


}
