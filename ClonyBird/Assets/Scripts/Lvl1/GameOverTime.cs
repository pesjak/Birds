using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverTime : MonoBehaviour {
	
	public float runTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	    runTime = PlayerPrefs.GetFloat ("savedCurTime");
		
		int minutes = Mathf.FloorToInt(runTime / 60F);
		int seconds = Mathf.FloorToInt(runTime - minutes * 60);
		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
		
		
		
		GetComponent<Text>().text = "Time: " + niceTime; 
	}
}
