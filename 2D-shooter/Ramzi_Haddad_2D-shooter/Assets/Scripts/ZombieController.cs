using UnityEngine;
using System.Collections;

public class ZombieController : MonoBehaviour {
	[SerializeField]
	private Vector2 speed = Vector2.zero;

	private Transform _transform;
	private Vector2 _currentPosition;

	//direction: positive when moving right, negative when moving left
	private int direction = 1;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;
		Vector2 currSpeed = new Vector2 (speed.x * direction, 0);
		_currentPosition -= currSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -10.3) {
			Reset ();
		}
	}

	public void Reset(){
		

		_currentPosition = new Vector2 (direction*10f, -1.5f);
		_transform.position = _currentPosition;
	}

}
