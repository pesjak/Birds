using UnityEngine;
using System.Collections;

public class GroundMove : MonoBehaviour {

	float speed = -2f;

	void FixedUpdate()

	{
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime /2;
		transform.position=pos;
	}
}
