using UnityEngine;
using System.Collections;

public class CameraConstant : MonoBehaviour {
	
	public float maxSpeed;
	
	private Vector3 startPosition;

	// Use this for initialization
	void Start () {	
		maxSpeed = 1f;
		
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(startPosition.x + (Time.time * maxSpeed),transform.position.y , transform.position.z);

		maxSpeed = maxSpeed + 0.0001f;

	}
}
