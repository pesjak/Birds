using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Advertisements;

public class Select : MonoBehaviour {


	//id 39368
	RuntimePlatform platform = Application.platform;


	bool  timer = false;
	float tTime;

	public int FPS=60;
	public float move = 5f;




	GameObject Selected1,Selected2, Selected3;
	GameObject WhiteBird,BlackBird;//Fly;

	int clicked1=0, clicked2= 0; //clicked3= 0;

	void Awake()
	{

		///ADS


		Application.targetFrameRate = FPS;

		Selected1 = GameObject.Find("Selected1");
	//	Selected2 = GameObject.Find("Selected2");
	//	Selected3 = GameObject.Find("Selected3");

		WhiteBird = GameObject.Find ("WhiteBird");
	//	BlackBird = GameObject.Find ("BlackBird");
//		Fly = GameObject.Find ("Fly");


		Selected1.SetActive (false);
//		Selected2.SetActive (false);
//		Selected3.SetActive (false);

//		//Debug.Log("Active Self: " + Selected1.activeSelf);
//		//Debug.Log("Active in Hierarchy" + Selected1.activeInHierarchy);


	}

	void  Update (){


				int nbTouches = Input.touchCount;
			
				if (nbTouches > 0) {
						for (int i = 0; i < nbTouches; i++) {
								Touch touch = Input.GetTouch (i);
					
								if (touch.phase == TouchPhase.Began) {
										Ray screenRay = Camera.main.ScreenPointToRay (touch.position);
						
									RaycastHit hit;
//										if (Physics.Raycast (screenRay, out hit)) {
//												//Debug.Log ("User tapped on game object " + hit.collider.gameObject.name);
//												handleTap (hit);
//										}
								}
					
						}
				}
		if(Input.GetMouseButtonDown(0)) {
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			if(hit.collider != null)
			{
				//Debug.Log ("Target Position: " + hit.collider.gameObject.name);
				handleTap(hit);
			}
		}

		if (clicked1 >= 2) {
			WhiteBirdClicked2();
			//	Application.LoadLevel ("test");
		}
//		if (clicked2 >= 2) {
//	//		BlackBirdClicked2();
//		}
		
	}
	
	void handleTap(RaycastHit2D hit)
	{
		if (hit.collider.gameObject.name == "WhiteBirdSelected") {
						if (WhiteBird.GetComponent<Animator> ().enabled == false || clicked1 <= 2) {
								clicked2 = 0;
								//clicked3=0;
								WhiteBird.GetComponent<Animator> ().enabled = true;
								//	BlackBird.GetComponent<Animator> ().enabled = false;
								//	Fly.GetComponent<Animator>().enabled =false;

				
								Selected1.SetActive (true);
								//	Selected2.SetActive (false);
//								Selected3.SetActive (false);

								clicked1++;
								//Debug.Log (clicked1);
								
//				StartCoroutine(Wait2Load());

						}


//			Selected1.SetActive(true);
//			Selected2.SetActive(false);
//			Selected3.SetActive(false);
						//Debug.Log ("White");
				}
//				} else if (hit.collider.gameObject.name == "BlackBirdSelected") {
//						if (BlackBird.GetComponent<Animator> ().enabled == false || clicked2 <= 2) {
//								clicked1 = 0;
//								//	clicked3=0;
//								WhiteBird.GetComponent<Animator> ().enabled = false;
//								BlackBird.GetComponent<Animator> ().enabled = true;
//								//Fly.GetComponent<Animator>().enabled =false;
//
//				
//								Selected1.SetActive (false);
//								Selected2.SetActive (true);
//					//			Selected3.SetActive (false);
//								clicked2++;
////				StartCoroutine(Wait2Load());
//
//
//
//						}
//
//
//
//						//Selected2.GetComponent<Animator>().enabled = true;
////			Selected1.SetActive(false);
////			Selected2.SetActive(true);
////			Selected3.SetActive(false);
//
//						//Debug.Log ("Black");
//				}
//		}else if (hit.collider.gameObject.name == "FlySelected") {
//			if(Fly.GetComponent<Animator>().enabled == false || clicked3<=2)
//			{
//				clicked1=0;
//				clicked2=0;
//			WhiteBird.GetComponent<Animator>().enabled =false;
//			BlackBird.GetComponent<Animator>().enabled =false;
//			Fly.GetComponent<Animator>().enabled =true;
//				
//				Selected1.SetActive (false);
//				Selected2.SetActive (false);
//				Selected3.SetActive (true);
//				clicked3++;
////				StartCoroutine(Wait2Load());
//				if(clicked3 >= 2)
//				{
//					//Application.LoadLevel("test");
//						Application.LoadLevel("FlyScene");
//					
//				}
//			}
//
//
//
//		//	Selected3.GetComponent<Animator>().enabled = true;
////			Selected1.SetActive(false);
////			Selected2.SetActive(false);
////			Selected3.SetActive(true);
//			//Debug.Log("Fly");
//		}




	}

	void WhiteBirdClicked2()
	{
//		int twice;
//
//		twice = PlayerPrefs.GetInt ("doublepoints", 0);

					
//DELA
			if (WhiteBird.transform.position.y > -2.3f) {
				WhiteBird.transform.position = new Vector2 (WhiteBird.transform.position.x, WhiteBird.transform.position.y - move / 200);
			} else {
//			if(twice!=0)
//			{
//			GameObject go = GameObject.Find ("UnityAdsManager");
//			UnityAdsHelper other = (UnityAdsHelper)go.GetComponent (typeof(UnityAdsHelper));
//
//			other.ShowTestAd ();
//			
//			}
			Application.LoadLevel ("testA");
				
			}


	}
//	void BlackBirdClicked2()
//	{
//		if (BlackBird.transform.position.y > -2.3f) {
//			BlackBird.transform.position = new Vector2 (BlackBird.transform.position.x, BlackBird.transform.position.y - move / 200);
//		} else {
//			
//			Application.LoadLevel ("level1");
//		}
//	}
//	IEnumerator Wait2Load()
//	{
//		yield return new WaitForSeconds (2);
//	}




}