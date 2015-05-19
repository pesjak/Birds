using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class HighScoreMenu : MonoBehaviour {

	public static int highScore = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		highScore = PlayerPrefs.GetInt("highScore", 0);
		
		GetComponent<Text> ().text = "High Score: " + highScore;
		
	}



//	public static int highScore = 0;
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		highScore = PlayerPrefs.GetInt("highScore", 0);
//
//		GetComponent<GUIText> ().text = "High Score: " + highScore;
//
//	}
}
