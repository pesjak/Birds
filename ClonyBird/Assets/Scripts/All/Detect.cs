using UnityEngine;
using System.Collections;

public class Detect : MonoBehaviour {
	bird_movement bird;
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Detect") {	
				bird.didFlap= true;
		}
	}
	}
