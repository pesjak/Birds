using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Net;

public class CheckDouble : MonoBehaviour {

	public GameObject doubleON;
	public GameObject always;


	public int twice;

	// Use this for initialization
	void Awake () {
	
		twice = PlayerPrefs.GetInt ("doublepoints", 0);


		if (twice == 0) {
			//doubleON = GameObject.Find ("DoublePointsText");
				} else if (twice != 0) {
			always.SetActive(true);

		}


	}

}
