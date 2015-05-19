using UnityEngine;
using System.Collections;

public class AutomaticUpDown : MonoBehaviour {

	public int maxSpeed;
		
		private Vector3 startPosition;
		
		// Use this for initialization
		void Start () 
		{
			maxSpeed = 4;
			
			startPosition = transform.position;
		}
		
		// Update is called once per frame
		void Update ()
		{
			MoveVertical ();
	}
		
		void MoveVertical()
		{
			transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);
			
			if(transform.position.y > 0.8f)
			{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			}
			else if(transform.position.y < -0.8f)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			}
		}
}
