using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{
	[SerializeField] 
	private float speed;






	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		// this for the cuurrent positon of the bullet
		Vector2 position = transform.position;
		//for the new position of the bullet
		position = new Vector2 (position.x + speed * Time.deltaTime, position.y);
		transform.position = position;// to assign the new location
		if (transform.position.x > 28f) {

			Destroy (gameObject);//  to destroy the bullets when it goes out of the bounds
		}


	}
}
