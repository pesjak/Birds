using UnityEngine;
using System.Collections;

public class StartTAP : MonoBehaviour {


	 static bool sawOnce = false;
	
//	GameObject TreeSpawnerPoint1;
//	GameObject TreeSpawnerPoint2;
//	GameObject TreeSpawnerPoint3;
	// Use this for initialization
	void Start () {
//		TreeSpawnerPoint1 = GameObject.Find ("TreeSpawnerPoint1");
//		TreeSpawnerPoint2 = GameObject.Find ("TreeSpawnerPoint2");
//		TreeSpawnerPoint3 = GameObject.Find ("TreeSpawnerPoint3");


		GetComponent<GUIText>().fontSize = 210;
		if(!sawOnce) {
			GetComponent<GUIText>().enabled = true;
			Time.timeScale = 0;
		}

	
		sawOnce = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale==0 && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) ) {
			Time.timeScale = 1;
			GetComponent<GUIText>().enabled = false;

			
//			TreeSpawnerPoint1.GetComponent<MeshRenderer> ().enabled = true;
//			TreeSpawnerPoint1.GetComponent<BoxCollider> ().enabled = true;
//			
//			TreeSpawnerPoint2.GetComponent<MeshRenderer> ().enabled = true;
//			TreeSpawnerPoint2.GetComponent<BoxCollider> ().enabled = true;
//			
//			TreeSpawnerPoint3.GetComponent<MeshRenderer> ().enabled = true;
//			TreeSpawnerPoint3.GetComponent<BoxCollider> ().enabled = true;
		}
	}
}
