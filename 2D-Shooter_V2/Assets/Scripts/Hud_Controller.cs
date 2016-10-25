using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hud_Controller : MonoBehaviour
{

	[SerializeField] Text Points = null;
	[SerializeField] Text health=null;

	// Use this for initialization
	void Start ()
	{
		Player.Instance.hud = this;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void updatePoints ()
	{

		Points.text = "Points :" + Player.Instance.points;

	}

	public void updateHealth(){
		health.text="Health:" + Player.Instance.Health;
	}




}
