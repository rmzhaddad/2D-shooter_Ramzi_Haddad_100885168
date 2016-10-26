using UnityEngine;
using System.Collections;

public class GunShotAnimationController : MonoBehaviour {


	// to stop the bullet animation 
	void end()
	{
		Destroy (gameObject);
	}
}
