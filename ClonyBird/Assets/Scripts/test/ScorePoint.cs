using UnityEngine;
using System.Collections;




public class ScorePoint : MonoBehaviour {
	

	public AudioClip[] audioClip;

	void Awake () {
	}


 	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player" && GameObject.Find ("Eagle").GetComponent<bird_movement> ().dead==false) {
			Score.AddPoint();
			PlaySound(0);
		}else if (collider.tag == "Player") {
			//Debug.Log("+1");
			//Score.AddPoint2(); //not yet
		}
	}

	void PlaySound(int clip)
	{		
		AudioSource audio = GetComponent<AudioSource>();
		audio.clip = audioClip [clip];
		audio.Play ();


	}
}
