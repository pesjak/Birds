using UnityEngine;
using System.Collections;

public class GameManagerLevel1 : MonoBehaviour {

	// Use this for initialization
	public float restartDelay = 3f;
	
	Animator anim;
	float restartTimer;
	
	void Awake () {
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
 if (GameObject.Find ("Eagle").GetComponent<SensorAI> ().dead == true) {
			
			anim.SetTrigger ("GameOver");
			
			//			restartTimer += Time.deltaTime;
			//
			//			if(restartTimer >= restartDelay)
			//			{
			//
			//			}
		}
	}

}
