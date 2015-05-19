using UnityEngine;
using System.Collections;

public class SensorAI : MonoBehaviour {


	public AudioClip[] audioClip;

	Vector3 velocity = Vector3.zero;
	public float flapSpeed = 50f;  //9.8f da izničiš gravity
	public float forwardSpeed = 1f;

	public bool godMode = false;
	
	public bool TdidFlap = false;
	public bool MdidFlap = false;
	public bool LdidFlap = false;

	public bool didFlap = false;
	
	Animator animator;
	
	public bool dead = false;
	
	GameObject floor;


	/// <summary>
	/// T////	/// </summary>
	/// 

	bool waitActive = false;


	public Transform TdetectStart, TdetectEnd;
	public Transform MdetectStart, MdetectEnd;
	public Transform LdetectStart, LdetectEnd;
	public Transform detectStart, detectEnd;

	public bool Tspotted=false;
	public bool Mspotted=false;
	public bool Lspotted=false;

	public bool spotted=false;


	GameObject target;

	public float move = 5f;
	void Start(){

		animator = transform.GetComponentInChildren<Animator> ();
		target = GameObject.Find("Floordetect");
	}

	void Update(){

		CheckKeyInput ();
		CheckTouchInput ();


		Raycasting ();
		Behaviours();

	}
	void CheckTouchInput()
	{
		if (Input.touchCount > 0) {
//			if (Input.touches [0].phase == TouchPhase.Began) {
//				if(dead == true)
//				{
//					//Application.LoadLevel(Application.loadedLevel); 
//					Application.LoadLevel ("MainMenu");
//				}
//			}
		}
		
	}

	void CheckKeyInput()
	{
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			
//			if(dead == true)
//			{
//				Application.LoadLevel(Application.loadedLevel); 
//				
//			}
		}
	}



	void Raycasting()
	{
		Debug.DrawLine (detectStart.position, detectEnd.position, Color.black);
		Debug.DrawLine (TdetectStart.position, TdetectEnd.position, Color.red);
		Debug.DrawLine (MdetectStart.position, MdetectEnd.position, Color.red);
		Debug.DrawLine (LdetectStart.position, LdetectEnd.position, Color.red);


		spotted = Physics2D.Linecast (detectStart.position, detectEnd.position, 1 << LayerMask.NameToLayer("Empty") );
		Tspotted = Physics2D.Linecast (TdetectStart.position, TdetectEnd.position, 1 << LayerMask.NameToLayer("Player") );
		Mspotted = Physics2D.Linecast (MdetectStart.position, MdetectEnd.position, 1 << LayerMask.NameToLayer("Player") );
		Lspotted = Physics2D.Linecast (LdetectStart.position, LdetectEnd.position, 1 << LayerMask.NameToLayer("Player") );


		if(spotted)
		{
			didFlap = true;
		}
		if (Tspotted ) {
			
			TdidFlap= true;

			
//			if(!waitActive){
//				StartCoroutine(Wait2());   //drugače ti skoz je true in ti nabija senzor, in poleti v nebo, POČAKA 2 SEKUNDI PREDN SE SPET AKTIVIRA  
//			}

		}
		if (Mspotted) {
			MdidFlap= true;
			
//			if(!waitActive){
//				StartCoroutine(Wait2());   //drugače ti skoz je true in ti nabija senzor, in poleti v nebo, POČAKA 2 SEKUNDI PREDN SE SPET AKTIVIRA  
//			}

			
		
		}
		if (Lspotted) {
			LdidFlap= true;
			
//			if(!waitActive){
//				StartCoroutine(Wait2());   //drugače ti skoz je true in ti nabija senzor, in poleti v nebo, POČAKA 2 SEKUNDI PREDN SE SPET AKTIVIRA  
//			}
			

		}


	}

	IEnumerator Wait2()
	{
		waitActive = true;
		//Debug.Log ("Waiting 2seconds");
		yield return new WaitForSeconds (2.0f);
		waitActive = false;
	}
	void Behaviours()
	{

	}

	void FixedUpdate () {
				if (dead) 
						return;
				//flapSpeed=Random.Range(birdMin, birdMax);
				//rigidbody2D.velocity = Vector2.zero;	
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * forwardSpeed);
		
				if (didFlap) {
						GetComponent<Rigidbody2D> ().AddForce (Vector2.up * flapSpeed );
						//	animator.SetTrigger ("DoFlap");
						animator.SetTrigger ("DoFlap");

						didFlap = false;
						flapSpeed = 50f;
				} 

		if (Tspotted && Mspotted) {
			if(target.transform.position.y > -0.81f)
			{
				target.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y-move/3f); //preskok
			}
			
		} else if (Tspotted && Lspotted) {

			if(target.transform.position.y > 0.15f)
			{
				target.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y-move/9);
			}else if(target.transform.position.y < 0.15f)
			{
				target.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y+move/6);
			}
		} else if (Lspotted && Mspotted) {
			if(target.transform.position.y < 0.78f)
			{
				target.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y+move/3f); //preskok
			}
		}






//			for(float i=-0.8f; i < 0.6f ; i+0.1f )
//			{
//
//						//target.transform.position = new Vector2 (positionx, i);		
//			}



		else {
			if(target.transform.position.y < 0.2f)
			{
				target.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y+move/5);
			}else
			{
				target.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y-move/5);

			}
		}
	


//
//		else if (TdidFlap && MdidFlap) {
//						// flapSpeed = 30f;
//
//						TdidFlap = false;
//						MdidFlap = false;
//
//
//		}else if (TdidFlap && LdidFlap) {
//		//	flapSpeed = 70f;
//
//
//			TdidFlap = false;
//			LdidFlap = false;
//
//
//		}else if (LdidFlap && MdidFlap) {
//		//	flapSpeed = 150f;
//
//			LdidFlap = false;
//			MdidFlap = false;
//		}
	


		if (GetComponent<Rigidbody2D>().velocity.y > 0) {		
			
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else {
			float angle = Mathf.Lerp (0, -90, (-GetComponent<Rigidbody2D>().velocity.y / 9));
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}



	}


	void OnCollisionEnter2D(Collision2D collison)
	{
		animator.SetTrigger ("Death");
		dead = true;
		PlaySound (0);
		
		
	}
	



	void PlaySound(int clip)
	{		
		AudioSource audio = GetComponent<AudioSource>();
		audio.clip = audioClip [clip];
		audio.Play ();
		
		
	}

	//////

}

//	Vector3 velocity = Vector3.zero;
//	public float flapSpeed = 50f;  //9.8f da izničiš gravity
//	float forwardSpeed = 1f;
//	
//	public float birdMax = 50f;
//	public float birdMin = 10f;
//	
//	int i=0;
//	
//	public bool godMode = false;
//	
//	public bool didFlap = false;
//	
//	Animator animator;
//	
//	public bool dead = false;
//	
//	GameObject floor;
//	
//	public AudioClip[] audioClip;
//	
//	void Start(){
//		animator = transform.GetComponentInChildren<Animator> ();
//	}
//	
//	//grafika in input
//	void Update() {
//		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
//			
//			if(dead == true)
//			{
//				Application.LoadLevel(Application.loadedLevel); 
//				
//			}
//		}
//		CheckTouchInput ();
//		
//		
//	}
//	void CheckTouchInput()
//	{
//		if (Input.touchCount > 0) {
//			if (Input.touches [0].phase == TouchPhase.Began) {
//				if(dead == true)
//				{
//					Application.LoadLevel(Application.loadedLevel); 
//					
//				}
//			}
//		}
//		
//	}
//	
//	
//	
//	
//	// fizika
//	void FixedUpdate () {
//		if (dead) 
//			return;
//		
//		//Debug.Log (flapSpeed);
//		
//		//flapSpeed=Random.Range(birdMin, birdMax);
//		//rigidbody2D.velocity = Vector2.zero;	
//		GetComponent<Rigidbody2D>().AddForce (Vector2.right * forwardSpeed);
//		
//		if (didFlap) {
//			
//			GetComponent<Rigidbody2D>().AddForce (Vector2.up * flapSpeed *2f);
//			animator.SetTrigger ("DoFlap");
//			
//			didFlap = false;
//		}
//		if (GetComponent<Rigidbody2D>().velocity.y > 0) {		
//			
//			transform.rotation = Quaternion.Euler (0, 0, 0);
//		} else {
//			float angle = Mathf.Lerp (0, -90, (-GetComponent<Rigidbody2D>().velocity.y / 3));
//			transform.rotation = Quaternion.Euler (0, 0, angle);
//		}
//		
//	}
//	
//	void OnCollisionEnter2D(Collision2D collison)
//	{
//		if(godMode)
//			return;
//		animator.SetTrigger ("Death");
//		dead = true;
//		//PlaySound (0);
//		
//		
//		
//		
//	}
//	void OnTriggerEnter2D(Collider2D collider)
//	{
//		if (collider.tag == "Detect") {	
//			
//			didFlap = true;
//		}
//		//		else if (collider.tag == "SensorTop") {	
//		//			//Debug.Log("TOP");
//		//			flapSpeed=Random.Range(birdMin, 150f);
//		//			return;
//		//		} 
//		//		else if (collider.tag == "SensorMid") {
//		//
//		//			didFlap=true;
//		//		}
//		//		else if (collider.tag == "SensorLow") {
//		//			didFlap=true;
//		//		}
//	}
//	void OnTriggerStay2D(Collider2D collider){
//		if(collider.tag == "Detect")
//		{
//			didFlap = true;
//		}
//		
//	}

	/*bird_movement bird;


	public static bool sensortop=false;
	public static bool sensormid=false;
	public static bool sensorlow=false;

	public static bool sensortopmid=false;
	public static bool sensortoplow=false;
	public static bool sensormidlow=false;
//	void OnTriggerEnter2D(Collider2D collider)
//	{
//			
//		if (collider.tag == "SensorTop") 
//		{	
//			//Debug.Log ("Top");
//
//		}
//		else if (collider.tag == "SensorMid") {
//						//Debug.Log ("Mid");		
//				}
//		else if (collider.tag == "SensorLow") {
//						//Debug.Log ("Low: ");
//
//
//				}
//		}

	void FixedUpdate()
	{
		AI ();
	}
	void OnTriggerStay2D(Collider2D collider)
	{
				if (collider.tag == "SensorTop") 
		{	
			if(!sensortop)
			{
				sensortop=true;



				checktopmidlow ();
			}
						//Debug.Log ("Top");
		}
				else if (collider.tag == "SensorMid")
		{
			if(!sensormid)
			{
				sensormid=true;
				
				checktopmidlow ();
			}
					//Debug.Log ("Mid");		
		}				
		else if (collider.tag == "SensorLow") 
		{
			if(!sensorlow)
			{
			sensorlow=true;
				
			checktopmidlow ();
			}
			//Debug.Log ("low");		
		}
	}

	void checktopmidlow()
	{
		if (sensortop && sensormid) {
						sensortopmid = true;
						sensortop = false;
						sensormid = false;
				} else if (sensortop && sensorlow) {
						sensortoplow = true;
						sensortop = false;
						sensorlow = false;
				} else if (sensormid && sensorlow) {
						sensormidlow = true;
						sensormid = false;
						sensorlow = false;
				} else 
						return;
	}

	void AI()
	{
		if (sensortopmid) {	
			GameObject.Find ("Eagle").GetComponent<bird_movement> ().flapSpeed = 50f;
		//GameObject.Find ("Eagle").GetComponent<bird_movement> ().didFlap=true;

			sensortopmid = false;
				} else if (sensormidlow) {
						GameObject.Find ("Eagle").GetComponent<bird_movement> ().flapSpeed = 180f;
		//	GameObject.Find ("Eagle").GetComponent<bird_movement> ().didFlap=true;
			sensormidlow = false;
				} else if (sensortoplow) {

						GameObject.Find ("Eagle").GetComponent<bird_movement> ().flapSpeed = 100f;
		//	GameObject.Find ("Eagle").GetComponent<bird_movement> ().didFlap=true;

						sensortoplow = false;
				}
	}

*/
