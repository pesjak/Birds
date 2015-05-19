using UnityEngine;
using System.Collections;

public class Pause_Game : MonoBehaviour {
	
	bool Pause = false;


	void Awake () {

	}
	void Update()
	{
		
		if (Pause == false)
		{
			Time.timeScale = 1;

		}

		
		else 
		{			
			Time.timeScale = 0;
		}

		
		
	}

	public void pausing()
	{
		if (Pause == true)
		{
			Pause = false;

		}
		
		else
		{
			Pause = true;
		}
	}

}
