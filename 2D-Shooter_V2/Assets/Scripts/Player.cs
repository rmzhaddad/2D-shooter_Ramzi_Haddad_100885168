using UnityEngine;
using System.Collections;

public class Player
{
	private static Player instance = null;

	public static Player Instance {

		get {
			if (instance == null) {

				instance = new Player (); // to assign the player object 
			
			}
			return instance;
		}
	

	}

	public Hud_Controller hud = null;//to assign the Hud 
	private int PlayerPoints = 0;

	public int points {
		get { 
		
			return PlayerPoints;
		}
		set { 
		
			PlayerPoints = value;
			hud.updatePoints ();
		}

	}
	private int playerhealth= 100;
	public int Health{

		get{return playerhealth;}
		set{ playerhealth = value;
			hud.updateHealth();
		}


	}
	private int numberOfEnemies = 1;// the number of enemies 
	public int NumOfEnemy{
		get{return numberOfEnemies; }
		set{numberOfEnemies = value; }
	}






}
