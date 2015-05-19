using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using System.Net;

public class ChangeScene : MonoBehaviour {


	public void ChangeToScene(int SceneToChangeTo)
	{
		GameObject retry = GameObject.Find ("RetryWithAds");
		
		if (retry.GetComponent<Button> ().interactable != false) {
						PlayerPrefs.SetInt ("doublepoints", 0);
						Application.LoadLevel (SceneToChangeTo);
				
				} else {
			Application.LoadLevel (SceneToChangeTo);
		}
	}

	public void ClickForAd()
	{
//		GameObject retry = GameObject.Find ("RetryWithAds");
//		retry.GetComponent<Button> ().interactable = false;
		PlayerPrefs.SetInt ("doublepoints", 0);
				GameObject go = GameObject.Find ("UnityAdsManager");
				UnityAdsHelper other = (UnityAdsHelper)go.GetComponent (typeof(UnityAdsHelper));
		GameObject goretry = GameObject.Find ("ViewAdText");
		goretry.GetComponent<Text> ().text = "Check Your Internet Connection!"; 
		other.ShowTestAd ();





//
//				PlayerPrefs.SetInt ("doublepoints", 1);
//				GameObject retry = GameObject.Find ("RetryWithAds");
//
//
//				retry.GetComponent<Button> ().interactable = false;
//	
//
//
//				GameObject goretry = GameObject.Find ("ViewAdText");
//
//				goretry.GetComponent<Text> ().text = "Thank you!!!"; 

		}





}
