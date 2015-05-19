using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	float flapSpeed = 100f;  //9.8f da izničiš gravity

	public bool godMode = false;
	
	public bool didFlap = false;

	public bool dela= false;
	
	GameObject bird;

	GameObject floor;
	//grafika in input
	void Update() {
		if(dela== true)
	{
		if (Input.GetMouseButtonDown (0)) {
			didFlap = true;
			}

	 CheckTouchInput ();
		}
	}
	void CheckTouchInput()
	{
				if (Input.touchCount > 0) {

						if (Input.touches [0].phase == TouchPhase.Began) {
								didFlap = true;
						}
				}
		}
	
	
	
	// fizika
	void FixedUpdate () {
		if (didFlap) {
			GetComponent<Rigidbody2D>().AddForce (Vector2.up * flapSpeed * 2f);
			didFlap = false;
		}

		
	}
	void OnTriggerEnter2D(Collider2D collider)
	{		
		if (collider.tag == "EnableDisable") {	
		
			dela= true;
		
		}
		if (collider.tag == "Detect") {	

			didFlap = true;
		}
	}

	void OnTriggerExit2D(Collider2D colldier)
	{
		dela = false;
	}

}
