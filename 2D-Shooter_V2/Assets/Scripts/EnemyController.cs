using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
	[SerializeField]
	private Vector2 speed;
	private Transform EnemyTransform;
	private Vector2 Enemyposition;


	// Use this for initialization
	void Start ()
	{
		EnemyTransform = gameObject.GetComponent<Transform> ();
		Enemyposition = EnemyTransform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		//easy level enemy
		Enemyposition = EnemyTransform.position;
		Vector2 Enemyspeed = new Vector2 (speed.x,speed.y);
		Enemyposition -= Enemyspeed;
		EnemyTransform.position = Enemyposition;
		if(Enemyposition.x<-28f){
			Reset ();
			
		}

	}

	void Reset ()
	{
		Enemyposition = new Vector2 (28f,Random.Range(-10f,10f));
		EnemyTransform.position = Enemyposition;
	}

}
