using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hud_Controller : MonoBehaviour
{

	public GameObject Maincharacter;
	public GameObject enemy;
	//public Transform MainCharPlace;
// to place the instance on maincamera

	[SerializeField] Text Points = null;// to capture the points label
	[SerializeField] Text health = null;//to caputure the health label
	[SerializeField] Button RestartGameButton = null; // to capture the restart button
	[SerializeField] Text GameOverLabel = null;




	// Use this for initialization
	void Start ()
	{
		
		Player.Instance.hud = this;// to connect the Player object to the current countroller
		RestartGame ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Player.Instance.Health <= 0) {
		
			GameOver ();
		}
	}
	// to update the points 
	public void updatePoints ()
	{

		Points.text = "Points :" + Player.Instance.points;

	}
	// to update the health
	public void updateHealth ()
	{
		health.text = "Health:" + Player.Instance.Health;
	}
	// to set the gameover enviroment
	void GameOver ()
	{
	
		health.gameObject.SetActive (false);//to hide the health points from the screen
		Points.gameObject.SetActive (false);//to hide the points label from the main screen 
		GameOverLabel.gameObject.SetActive (true);// to show the gameover label from main screen
		RestartGameButton.gameObject.SetActive(true);// to show the restart button
		Player.Instance.Health=0;

		
	
	}
	// to restart the game when the main character is dead
	public void RestartGame ()
	{
	
		// to restore the health and the points label
		GameOverLabel.gameObject.SetActive (false);// to remove the gameover label from main screen
		health.gameObject.SetActive (true);//to restore the health to mainscreen
		Points.gameObject.SetActive (true);//to restore the points to mainscreen
		Player.Instance.points = 0;//to reset the points counter
		Player.Instance.NumOfEnemy = 0;//to reset the enemy counter
		Player.Instance.Health = 100;// to reset the health counter
		RestartGameButton.gameObject.SetActive (false);// to remove the restart button from the screen
		// to create a main character instance
		GameObject MainChar = (GameObject)Instantiate (Maincharacter);

	// to create a new enemy instance 
		GameObject Enemy2 = (GameObject)Instantiate (enemy);
		Player.Instance.NumOfEnemy++;// to keep track of the enemy for the logic
	
	}




}
