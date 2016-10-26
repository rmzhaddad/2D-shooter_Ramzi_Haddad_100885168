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
		// to generate enemy in random place on the screen
		EnemyTransform = gameObject.GetComponent<Transform> ();
		Enemyposition = EnemyTransform.position;
		Reset ();
		Reset ();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{	//easy level enemy	
		Enemyposition = EnemyTransform.position;
		if (Player.Instance.points < 30) {

			Vector2 Enemyspeed = new Vector2 (speed.x, speed.y);
			Enemyposition -= Enemyspeed;
		}
		//for mediumn level enemy 
		if (Player.Instance.points >=30&& Player.Instance.points<=60) {

			Vector2 Enemyspeed = new Vector2 (speed.x*3, speed.y);
			Enemyposition -= Enemyspeed;
		}// for hard level enemy
		if (Player.Instance.points >=60&& Player.Instance.points<=99) {

			Vector2 Enemyspeed = new Vector2 (speed.x*4, speed.y);
			Enemyposition -= Enemyspeed;
		}
		//for the advanced player only
		if (Player.Instance.points >=100) {

			Vector2 Enemyspeed = new Vector2 (speed.x*7, speed.y);
			Enemyposition -= Enemyspeed;
		}
			
		EnemyTransform.position = Enemyposition;
		if(Enemyposition.x<-28f){
			Reset ();
			
		}

	}

	void Reset ()
	{
		Enemyposition = new Vector2 (28f,Random.Range(-12f,12f));
		EnemyTransform.position = Enemyposition;
	}

}
