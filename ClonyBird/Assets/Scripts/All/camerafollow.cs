using UnityEngine;
using System.Collections;

public class camerafollow : MonoBehaviour {

	Transform player;

	SensorAI scriptAI;
	//bird_movement BM;
	float offsetX;
	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;


		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");

		if(player_go == null)
		{
			//Debug.LogError("Couldn't find it");
			return;
	}
		player = player_go.transform;
		offsetX = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			Vector3 pos = transform.position;
			pos.x = player.position.x + offsetX;
			transform.position = pos;
		}
	
	}
}
