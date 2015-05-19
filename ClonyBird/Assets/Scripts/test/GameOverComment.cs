using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameOverComment : MonoBehaviour {
	public static int score = 0;

	void Update () {
		score = PlayerPrefs.GetInt("score");

		if (score >= 0 && score <= 1)
						GetComponent<Text> ().text = "WONDERING How to play? Figure it out yourself";
		else if(score>=2 && score <=3)
			GetComponent<Text> ().text = "Do you even?";
		else if(score>=3 && score <=6)
			GetComponent<Text> ().text = "Getting better";
		else if(score>=12 && score <=18)
			GetComponent<Text> ().text = "Okay you learned to play CONGRATS";
		else if(score>=18 && score <=25)
			GetComponent<Text> ().text = "Are you cheating???";
		else if(score>=25 && score <=30)
			GetComponent<Text> ().text = "Okay this is just crazy...";
		else if(score>=30 && score <=35)
			GetComponent<Text> ().text = "Well you beat my highscore:32, and i created the game." ;
		else if(score>=35 && score <=50)
			GetComponent<Text> ().text = "K... I GET IT YOU ARE GOOD";
	}

}
