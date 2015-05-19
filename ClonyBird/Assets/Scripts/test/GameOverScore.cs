using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScore : MonoBehaviour {
	public static int score = 0;
	
//	public static GameOverScore instance;

	// Use this for initialization
	void Start () {
	//	instance = this;
		//score = PlayerPrefs.GetInt("score");
		//Text text = textgameobject.GetComponent<Text>(); 

	}
	
	// Update is called once per frame
	void Update () {
		score = PlayerPrefs.GetInt("score");
		GetComponent<Text> ().text = "Score: " + score;


		}
}
