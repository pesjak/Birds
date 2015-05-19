using UnityEngine;
using System.Collections;

public class DeathScreen : MonoBehaviour {
//
//	/*
//	static int score = 0;
//	static int highScore = 0;
//	static int deaths = 0;
//	*/
//	
//	//  static DeathScreen instance;
//
//	public int highscore1;
////	public  int death1;
//	public int score1;
//	
//
//	void Start() {
//				GetComponent<GUIText>().fontSize = 120;
//				GetComponent<GUIText>().color = Color.yellow;
//		}
//	void Update () {
//		highscore1 = Score.highScore;
//	//	death1 = Score.death;
//		score1 = Score.score;
//		GetComponent<GUIText>().text = "Score: "+score1+"\nRecord: " + highscore1; //+ "\nYOU CRASHED: " + death1 + " TIMES";
//		if((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) ) {
//			Wait ();
//			GetComponent<GUIText> ().enabled = false;
//		}
//		
//		if (GameObject.Find ("Eagle").GetComponent<bird_movement> ().dead) {
//			GetComponent<GUIText> ().enabled = true;
//
//		}
//		
//	}

//	
//	/*static public void AddPoint() {
//		score++;
//		
//		if(score > highScore) {
//			highScore = score;
//		}
//		if (GameObject.Find ("Eagle").GetComponent<bird_movement> ().dead) {
//			deaths ++;		
//		}
//	}
//	
//	void Start() {
//		guiText.fontSize = 40;
//		guiText.color = Color.yellow;
//		instance = this;
//
//
//		score = 0;
//		highScore = PlayerPrefs.GetInt("highScore", 0);
//		deaths = PlayerPrefs.GetInt ("deaths", 0);
//	}
//
//
//	
//	void OnDestroy() {
//		instance = null;
//		PlayerPrefs.SetInt("highScore", highScore);
//		PlayerPrefs.SetInt ("deaths", deaths);
//	}
//
//
	IEnumerator Wait() {  //ni uporabljena še
		
		
		yield return new WaitForSeconds (3f);
		
		
	}

}