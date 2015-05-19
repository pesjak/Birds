using UnityEngine;
using System.Collections;

public class GUITimer : MonoBehaviour {


	public float savedTime;
	public float runTime;
	void Start() {
		//PlayerPrefs.GetFloat ("runTime", runTime); 


		savedTime = PlayerPrefs.GetFloat ("savedTime",969696);

		if (savedTime < 1) {
			PlayerPrefs.SetFloat("savedTime",969696);
		}
	}

		void Update()
		{


				if (GameObject.Find ("Eagle").GetComponent<SensorAI> ().dead == false) {
						runTime += Time.deltaTime;
				} else {	
						savedTime = PlayerPrefs.GetFloat ("savedTime");
						if (runTime < savedTime) {
			

								//Debug.Log ("saving");

								PlayerPrefs.SetFloat ("savedTime", runTime);
						} else {

//			}else if(runTime>savedTime){
//
//				PlayerPrefs.SetFloat("savedTime",969696);
//			}


								PlayerPrefs.SetFloat ("savedCurTime", runTime);
						}
				}
		}

		

	
	void OnGUI () {



		//devanje v format 0:00
		int minutes = Mathf.FloorToInt(runTime / 60F);
				int seconds = Mathf.FloorToInt(runTime - minutes * 60);
				string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);


		savedTime = PlayerPrefs.GetFloat ("savedTime");
		

		int minutes1 = Mathf.FloorToInt(savedTime / 60F);
		int seconds1 = Mathf.FloorToInt(savedTime - minutes1 * 60);
		string savedTimeComplete = string.Format("{0:0}:{1:00}", minutes1, seconds1);


		GetComponent<GUIText>().text = "Time: " + niceTime + "\nBest Time: " + savedTimeComplete;  //PRIKAZOVANJE
		//+ "\nTotal Time: " + runTime + Time.timeSinceLevelLoad.ToString ("F2");
	}

}









//	public static float timer; 
//
//	void Update()
//	{
//		if (GameObject.Find ("Eagle").GetComponent<bird_movement> ().dead == false) {
//						timer += Time.deltaTime;
//				} else {
//			Score.TimerSave(timer);		
//		}
//	}
//	void OnGUI() {
//		int minutes = Mathf.FloorToInt(timer / 60F);
//		int seconds = Mathf.FloorToInt(timer - minutes * 60);
//		
//		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
//		
//		GUI.Label(new Rect(30,10,250,100), "Time: "+niceTime);
//	}
//
//}





/////////
//	public static float time1=1000, prevtime=1000, besttime=999;

//public static void TimerSave(float timer)
//{
//	prevtime = PlayerPrefs.GetFloat ("bestTime", time1);
//	
//	if(timer < prevtime)
//	{
//		besttime = timer;
//	}
//	
//	
//}
//PlayerPrefs.SetFloat ("bestTime", besttime);
