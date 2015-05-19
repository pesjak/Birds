using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	public static int score = 0;
	public static int highScore = 0;
	public static int sum = 0;

	public static Score instance;
	bird_movement bird;


	public static int twice;

	public static void AddPoint() {
		if(instance.bird.dead)

			return;


//		// double score
//		if (twice == 0) {
//						score++;
//				} else if(twice !=0){
//			score=score+2;	
//			//score++;
//
//		}

		score++;
		
		if(score > highScore) {
			highScore = score;
		}
	}



	
	void Start() {

		twice = PlayerPrefs.GetInt ("doublepoints", 0);

		instance = this;
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		if(player_go == null) {
			//Debug.LogError("Could not find an object with tag 'Player'.");
		}
		
		bird = player_go.GetComponent<bird_movement>();

			highScore = PlayerPrefs.GetInt("highScore", 0);
	}
	
	void OnDestroy() {
		instance = null;

		if (twice == 0) {
			score = 0;
		}
		PlayerPrefs.SetInt("score", score);
		PlayerPrefs.SetInt("highScore", highScore);
	}
	
	void Update () {
		if (GameObject.Find ("Eagle").GetComponent<bird_movement> ().dead == true && twice == 0) {
						PlayerPrefs.SetInt ("score", score);
						PlayerPrefs.SetInt ("highScore", highScore);
		} else  if(GameObject.Find ("Eagle").GetComponent<bird_movement> ().dead == true && twice != 0) {

			StartCoroutine(TaskOne());
		}

						GetComponent<Text> ().text = "Score: " + score + "\nHigh Score: " + highScore;
				
	}

	IEnumerator TaskOne()
	{           
//		while (true) {
						yield return new WaitForSeconds (1f);
						PlayerPrefs.SetInt ("doublepoints", 0);
						Application.LoadLevel ("test");
			//	}
	}

	
//	public static int score = 0;
//	public static int highScore = 0;
//	public static int death = 0;
//
//	
//	static Score instance;
//	
//	static public void AddPoint() {
//		score++;
//		
//		if(score > highScore) {
//			highScore = score;
//		}
//	if (GameObject.Find ("Eagle").GetComponent<bird_movement> ().dead) {
//			death ++;	
//			//Debug.Log("Deeath");
//		}
//
//	}
//
//	void Start() {
//		GetComponent<GUIText>().fontSize = 110;
//		instance = this;
//
//		score = 0;
//		highScore = PlayerPrefs.GetInt("highScore", 0);
//		death = PlayerPrefs.GetInt ("death", 0);
//
//	}
//	
//	void OnDestroy() {
//				instance = null;
//				PlayerPrefs.SetInt ("highScore", highScore);
//				PlayerPrefs.SetInt ("death", death);
//		}
//	
//	void Update () {
//		if (GameObject.Find ("Tap To Start").GetComponent<GUIText> ().enabled == false && GameObject.Find ("Eagle").GetComponent<bird_movement> ().dead == false) {
//						GetComponent<GUIText> ().enabled = true;
//				} else {
//			GetComponent<GUIText> ().enabled = false;
//				}
//		GetComponent<GUIText>().text = "" + score; // "\nYOU CRASHED: " + death + " TIMES";
//}
}