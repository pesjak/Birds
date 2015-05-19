using UnityEngine;
using System.Collections;

public class KillTree : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collider)
	{	
		//Debug.Log ("Triggered: " + collider.name);
				if (collider.CompareTag ("TreeSpawn")) {
						Destroy (collider.gameObject);
				}
		}
}
