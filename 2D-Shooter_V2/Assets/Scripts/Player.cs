using UnityEngine;
using System.Collections;

public class Player
{
	private static Player instance = null;

	public static Player Instance {

		get {
			if (instance == null) {

				instance = new Player ();
			
			}
			return instance;
		}
	

	}

	public Hud_Controller hud = null;
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
			hud.updateHealth();}


	}






}
