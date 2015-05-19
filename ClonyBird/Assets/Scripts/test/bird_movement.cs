using UnityEngine;
using System.Collections;

public class bird_movement : MonoBehaviour {

	
	Vector3 velocity = Vector3.zero;
	public float flapSpeed = 50f;  //9.8f da izničiš gravity
	public float forwardSpeed = 1f;
	
	public AudioClip[] audioClip;

	public GameObject one, two, three, four, five, six, seven,eight;


	public bool godMode = false;

	public bool didFlap = false;
	
	Animator animator;
	
	public bool dead = false;
	
	GameObject target;
	
	public float move = 0.5f;

	Vector3 direction;


	public Transform detectStart, detectEnd;
	
	public bool spotted=false;

	public float randomResult;

	void Start(){

		animator = transform.GetComponentInChildren<Animator> ();

//		one = GameObject.Find ("BGScreenFader");
//		two = GameObject.Find ("ScreenFader");
//		three = GameObject.Find ("GameOverText");
//		four = GameObject.Find ("HighScoreText");
//		five = GameObject.Find ("ScoreText");
//		six = GameObject.Find ("Menu");
//		seven = GameObject.Find ("Retry");



		target = GameObject.Find("Floordetect");
		StartCoroutine (RandomPosTarget());


	}
	void Update(){
		
	CheckTouchInput ();
		Raycasting ();

	}

	void CheckTouchInput()
	{
		if (Input.touchCount > 0) {
//			if (Input.touches [0].phase == TouchPhase.Began) {
//				if(dead == true)
//				{
//				//	Application.LoadLevel(Application.loadedLevel); 
//					Application.LoadLevel ("MainMenu");
//				}
//			}
		}
		
	}
	void Raycasting()
	{
				Debug.DrawLine (detectStart.position, detectEnd.position, Color.red);
		
		
				spotted = Physics2D.Linecast (detectStart.position, detectEnd.position, 1 << LayerMask.NameToLayer ("Empty"));
		
	//	//Debug.Log (spotted);
				if (spotted) {
		//	//Debug.Log("FLAP");
						didFlap = true;
				}
		}

	void FixedUpdate () {

		if (dead) {					
//		PlayerPrefs.SetInt ("doublepoints", 0);
						return;
				}		
		GetComponent<Rigidbody2D> ().AddForce (Vector2.right * forwardSpeed);
		
		if (didFlap) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * flapSpeed );
			//	animator.SetTrigger ("DoFlap");
			animator.SetTrigger ("DoFlap");
			////Debug.Log(didFlap);
			didFlap = false;
			flapSpeed = 50f;
		} 
	
			if(target.transform.position.y < randomResult)
			{
			target.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y+move/15f); 
			}
		else if(target.transform.position.y > randomResult)
		        {
			target.transform.position = new Vector2 (target.transform.position.x, target.transform.position.y-move/15f); 
		}



		// -0.8 bot,  0.1 mid, 0.8 top
		if (GetComponent<Rigidbody2D>().velocity.y > 0) {		
			
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else {
			float angle = Mathf.Lerp (0, -90, (-GetComponent<Rigidbody2D>().velocity.y / 10));
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}
		
		
		
	}
	
	IEnumerator RandomPosTarget()
		{
		while (true) {
			

			randomResult= Random.Range (-0.79f, 0.79f);
			//Debug.Log(randomResult);
	
			yield return new WaitForSeconds(1f);  //hard mode Random.Range(0.2f,4f)
				}

		}

	void OnCollisionEnter2D(Collision2D collison)
	{
		if(godMode)
		return;
		PlaySound(0);

		one.SetActive(true);
		two.SetActive (true);
		three.SetActive (true);
		four.SetActive (true);
		five.SetActive (true);
		six.SetActive (true);
		seven.SetActive(true);
		eight.SetActive(true);
				animator.SetTrigger ("Death");

				dead = true;

	}
	void PlaySound(int clip)
	{		
		AudioSource audio = GetComponent<AudioSource>();
		audio.clip = audioClip [clip];
		audio.Play ();
		
		
	}

}
