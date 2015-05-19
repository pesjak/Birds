using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour {

	public Sprite soundoff, soundon;
	public Button myBtn;

	public int sound;

	public bool runned=false;

	// Use this for initialization

	void Start(){
		//myBtn = GetComponent<Button> ();
		Check ();
	}
	void Update () {

						Check ();

	}


	public void Check()
	{
				sound = PlayerPrefs.GetInt ("sound", 1);

				if (sound == 0) {

						AudioListener.pause = true;
						AudioListener.volume = 0;
			myBtn.image.sprite = soundoff;
		
				} else {
			myBtn.image.sprite = soundon;
			AudioListener.pause = false;
			AudioListener.volume = 0.8f;
		}


	}


	public void Sound()
	{	
//		soundon = Resources.Load<Sprite>("SoundLoud");
//		soundoff = Resources.Load<Sprite>("Soundmute");

		if (sound == 0) {
						PlayerPrefs.SetInt ("sound", 1);
			myBtn.image.sprite = soundon;
				} else {
			PlayerPrefs.SetInt("sound",0);
			myBtn.image.sprite = soundoff;

		}

	}
}
