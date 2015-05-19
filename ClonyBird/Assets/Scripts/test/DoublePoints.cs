using UnityEngine;
using System.Collections;

public class DoublePoints : MonoBehaviour {

	public int twice;
	// Use this for initialization

	public void change()
	{
	twice = PlayerPrefs.GetInt ("doublepoints", 0);

		if (twice == 0) {
						PlayerPrefs.SetInt ("doublepoints", 1);
			//Debug.Log(twice);
		} else if (twice == 1){
			PlayerPrefs.SetInt("doublepoints",0);
			//Debug.Log(twice);

		}
	}
	

}
