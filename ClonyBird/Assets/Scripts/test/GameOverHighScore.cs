using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverHighScore : MonoBehaviour {

	public static int highScore = 0;


	//public static GameOverHighScore instance;
	
	// Use this for initialization
	void Start () {
	//	instance = this;
		//highScore = PlayerPrefs.GetInt("highScore", 0);
	//	Text text = textgameobject.GetComponent<Text>(); 

	}

	void Update () {
		highScore = PlayerPrefs.GetInt("highScore", 0);

			GetComponent<Text> ().text = "High Score: " + highScore;
		
	}
}
