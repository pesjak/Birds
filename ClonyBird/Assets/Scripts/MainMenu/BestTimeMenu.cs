using UnityEngine;
using System.Collections;

public class BestTimeMenu : MonoBehaviour {
	public float savedTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		savedTime = PlayerPrefs.GetFloat ("savedTime");

		int minutes1 = Mathf.FloorToInt(savedTime / 60F);
		int seconds1 = Mathf.FloorToInt(savedTime - minutes1 * 60);
		string savedTimeComplete = string.Format("{0:0}:{1:00}", minutes1, seconds1);
		
		
		GetComponent<GUIText>().text = "Best Time: " + savedTimeComplete;  //PRIKAZOVANJE
	}
}
