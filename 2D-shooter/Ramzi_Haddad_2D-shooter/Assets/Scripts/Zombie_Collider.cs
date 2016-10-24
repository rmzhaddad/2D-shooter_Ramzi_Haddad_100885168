using UnityEngine;
using System.Collections;

public class Zombie_Collider : MonoBehaviour {

	int r=0;
	void onTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Zombie") {
		
			Debug.Log ("it collides");
		}
	}





	void OnCollisionEnter2D(Collision2D other){
		

		Debug.Log ("Collision");

		ZombieController ZN = other.collider.gameObject.GetComponent<ZombieController> ();

		if (other.gameObject.tag == "Zombie") {
			if(r>=1)


			ZN.Reset ();

		}
		r++;
		}

}

