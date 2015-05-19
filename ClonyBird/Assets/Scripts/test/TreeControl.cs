using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
public class TreeControl : MonoBehaviour {
	private float dist;
	private bool dragging = false;
	private Vector3 offset;
	private Transform toDrag;
	Vector3 v3;

	void Update() {

		Touch ();

	}
	
	void Touch()
	{		
		if (Input.touchCount != 1) {
			dragging = false; 
			return;
		}
		
		Touch touch = Input.touches[0];
		Vector3 pos = touch.position;
		
		if(touch.phase == TouchPhase.Began) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(pos); 
			if(Physics.Raycast(ray, out hit) && (hit.collider.tag == "Tree"))
			{
				//Debug.Log ("Here");
				toDrag = hit.transform;
				dist = hit.transform.position.z - Camera.main.transform.position.z;
				v3 = new Vector3(pos.x, pos.y, 5);
				v3 = Camera.main.ScreenToWorldPoint(v3);
				offset = toDrag.position - v3;
				dragging = true;
			}
		}
		if (dragging && touch.phase == TouchPhase.Moved) {
			v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
			v3 = Camera.main.ScreenToWorldPoint(v3);
			toDrag.position = v3 + offset;
		}
		if (dragging && (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)) {
			dragging = false;
		}

		}


	/// <summary>
	/// T//	/// </summary>
	Vector3 screenPoint;


	float xMove;



	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 5);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint);
		
		//New line below:
		curPosition.x = transform.position.x;
		//----
		
		transform.position = curPosition;
	}


//
//	/ <summary>
//	/// GOR PA DOL TI SAMO GRE	/// </summary>

//
//	public int maxSpeed;
//	
//	private Vector3 startPosition;
//	
//	// Use this for initialization
//	void Start () 
//	{
//		maxSpeed = 3;
//		
//		startPosition = transform.position;
//	}
//	
//	// Update is called once per frame
//	void Update ()
//	{
//		MoveVertical ();
//	}
//	
//	void MoveVertical()
//	{
//		transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);
//		
//		if(transform.position.y > 1.0f)
//		{
//			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
//		}
//		else if(transform.position.y < -1.0f)
//		{
//			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
//		}
//	}
//
//



	/// <summary>
//	/// KAMORKOLI DRAG	/// </summary>
	
//	private Color mouseOverColor = Color.blue;
//	private Color originalColor = Color.yellow;
//	private bool dragging = false;
//	private float distance;
//
//	void OnMouseDown()
//	{
//		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
//		dragging = true;
//	}
//	
//	void OnMouseUp()
//	{
//		dragging = false;
//	}
//	
//	void Update()
//	{
//		if (dragging)
//		{
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			Vector3 rayPoint = ray.GetPoint(distance);
//			transform.position = rayPoint;
//		}
//	}

	////////ŠE EN NAČIN
//	
//	private Vector3 screenPoint;
//	
//	void OnMouseDown(){
//		screenPoint= Camera.main.WorldToScreenPoint (gameObject.transform.position);
//	}
//	void OnMouseDrag(){
//		Vector3 currentScreenPoint = new Vector2 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
//		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint.y);
//		transform.position = currentPos;
//}

}