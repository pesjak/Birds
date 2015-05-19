using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameOverBestTime : MonoBehaviour {
	
	public float savedTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//devanje v format 0:00

		savedTime = PlayerPrefs.GetFloat ("savedTime");  ///POPRAVI
		
		
		int minutes1 = Mathf.FloorToInt(savedTime / 60F);
		int seconds1 = Mathf.FloorToInt(savedTime - minutes1 * 60);
		string savedTimeComplete = string.Format("{0:0}:{1:00}", minutes1, seconds1);
		
		
		GetComponent<Text>().text = "Best Time: " + savedTimeComplete; 
	}
}
