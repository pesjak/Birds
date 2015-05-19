using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnTree : MonoBehaviour {

	public GameObject TreeSpawn;
	public int treeCount = 50;
	
	GameObject TreeSpawnerPoint1;
	GameObject TreeSpawnerPoint2;
	GameObject TreeSpawnerPoint3;

	GameObject Button1;
	GameObject Button2;
	GameObject Button3;

	public float time = 0f;
	public static bool tree1spwn=false;
	public static bool tree2spwn=false;
	public static bool tree3spwn=false;

	

	public Image b1a,b2a,b3a;

	void Start()
	{						
		Declare ();

	}

	public void Declare()
	{
		Button1 = GameObject.Find ("Button1");
		Button2 = GameObject.Find ("Button2");
		Button3 = GameObject.Find ("Button3");

		TreeSpawnerPoint1 = GameObject.Find ("TreeSpawnerPoint1");
		TreeSpawnerPoint2 = GameObject.Find ("TreeSpawnerPoint2");
		TreeSpawnerPoint3 = GameObject.Find ("TreeSpawnerPoint3");

		b1a = Button1.GetComponent<Image> ();
		b2a = Button2.GetComponent<Image> ();
		b3a = Button3.GetComponent<Image> ();


	}
	public void Update()
	{

 	CheckMouseInput();
//	CheckTouchInput();

	}
	
	public void CheckMouseInput()
	{

				if (Input.GetMouseButtonDown (0))
		{
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						RaycastHit hitTest;


						if (Physics.Raycast (ray, out hitTest))
			{					

				
					if (hitTest.collider == gameObject.GetComponent<Collider>())
				{
										
					if (hitTest.collider == TreeSpawnerPoint1.GetComponent<Collider>()) {
						tree1spwn = true;
						StartCoroutine (Wait3Tree1 ());
						SpawnTrees ();
					}
					if (hitTest.collider == TreeSpawnerPoint2.GetComponent<Collider>()) {
						tree2spwn = true;
						StartCoroutine (Wait3Tree1 ());
						SpawnTrees ();
					}
					if (hitTest.collider == TreeSpawnerPoint3.GetComponent<Collider>()) {
						tree3spwn = true;
						StartCoroutine (Wait3Tree1 ());
						SpawnTrees ();
					}



				
						
				}
			}
		}
	}

	public void spawn1()
	{
		tree1spwn = true;
		StartCoroutine (Wait3Tree1 ());
		SpawnTrees ();
	}
	public void spawn2()
	{
		tree2spwn = true;
		StartCoroutine (Wait3Tree1 ());
		SpawnTrees ();
	}
	public void spawn3()
	{
		tree3spwn = true;
		StartCoroutine (Wait3Tree1 ());
		SpawnTrees ();
		}
	
//	void CheckTouchInput()
//	{
//
//		if (Input.touchCount > 0) 
//		{
//
//			if(Input.touches[0].phase == TouchPhase.Began)
//			{
//				Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
//				RaycastHit hitTest;
//				
//				if(Physics.Raycast(ray,out hitTest))
//				{
//					if(hitTest.collider == gameObject.collider)
//					{
//
//						SpawnTrees(hitTest.point);
//					}
//				}
//			}
//		}
//	}
	
	public void SpawnTrees()
	{
		if (treeCount > 0) 
		{	
			if(tree1spwn== true && tree2spwn==true)
			{

				//Debug.Log("works1");
				//Debug.Log(TreeSpawnerPoint1.transform.position);
			Instantiate (TreeSpawn, TreeSpawnerPoint1.transform.position,TreeSpawn.transform.rotation);
			Instantiate (TreeSpawn, TreeSpawnerPoint2.transform.position ,TreeSpawn.transform.rotation);
				treeCount--;
				tree1spwn=false;
				tree2spwn=false;
			}
			else if(tree1spwn== true && tree3spwn==true)
			{
				//Debug.Log("works2");

				Instantiate (TreeSpawn, TreeSpawnerPoint1.transform.position,TreeSpawn.transform.rotation);
				Instantiate (TreeSpawn, TreeSpawnerPoint3.transform.position ,TreeSpawn.transform.rotation);
				treeCount--;
				tree1spwn=false;
				tree3spwn=false;
			}			
			else if(tree2spwn== true && tree3spwn==true)
			{
				//Debug.Log("works3");

				Instantiate (TreeSpawn, TreeSpawnerPoint2.transform.position,TreeSpawn.transform.rotation);
				Instantiate (TreeSpawn, TreeSpawnerPoint3.transform.position ,TreeSpawn.transform.rotation);
				treeCount--;
				tree2spwn=false;
				tree3spwn=false;
			}

			if(tree1spwn)
			{
				b1a.color = new Color(137f, 236, 80f, 0.5f);
//				Button1.GetComponent<Image>().enabled = false;
//				Button1.GetComponentInChildren<Text>().enabled = false;
			}
	
			if(tree2spwn)
			{
				b2a.color = new Color(137, 236, 80, 0.5f);

//				Button2.GetComponent<Image>().enabled = false;
//				Button2.GetComponentInChildren<Text>().enabled = false;
			}

			if(tree3spwn)
			{
				b3a.color = new Color(137, 236, 80, 0.5f);

//				Button3.GetComponent<Image>().enabled = false;
//				Button3.GetComponentInChildren<Text>().enabled = false;
			}
		}
	}

	int i = 0;

	IEnumerator Wait3Tree1() {


		if (tree1spwn == true && tree2spwn == true ||
			tree1spwn == true && tree3spwn == true ||
			tree3spwn == true && tree2spwn == true)
		{
			Button1.GetComponent<Image>().enabled = false;
			Button1.GetComponentInChildren<Text>().enabled = false;

			Button2.GetComponent<Image>().enabled = false;
			Button2.GetComponentInChildren<Text>().enabled = false;

			Button3.GetComponent<Image>().enabled = false;
			Button3.GetComponentInChildren<Text>().enabled = false;


//						TreeSpawnerPoint1.GetComponent<MeshRenderer> ().enabled = false;
//						TreeSpawnerPoint1.GetComponent<BoxCollider> ().enabled = false;
//
//						TreeSpawnerPoint2.GetComponent<MeshRenderer> ().enabled = false;
//						TreeSpawnerPoint2.GetComponent<BoxCollider> ().enabled = false;
//
//
//						TreeSpawnerPoint3.GetComponent<MeshRenderer> ().enabled = false;
//						TreeSpawnerPoint3.GetComponent<BoxCollider> ().enabled = false;
//
			float num1=Random.Range(0f,0.7f);
			float num2=Random.Range(0f,2f);

			if(i < 3)
			{
			
				yield return new WaitForSeconds (1.5f-num1);

				i++;
			}else
			{
				i=0;
				yield return new WaitForSeconds (1f+num2);

			}








			Button1.GetComponent<Image>().enabled = true;
			Button1.GetComponentInChildren<Text>().enabled = true;



			Button2.GetComponent<Image>().enabled = true;
			Button2.GetComponentInChildren<Text>().enabled = true;



			Button3.GetComponent<Image>().enabled = true;
			Button3.GetComponentInChildren<Text>().enabled = true;
	
			b1a.color = new Color(137/255f, 236/255f, 80/255f, 1f);
			b2a.color = new Color(137/255f, 236/255f, 80/255f, 1f);
			b3a.color = new Color(137/255f, 236/255f, 80/255f, 1f);
			//time= time+Random.Range(0f,0.5f);

//			if(time < 2)
//			{
//			time = time+0.5f;
//			//Debug.Log(time);
//			}else
//			{
//				//Debug.Log(time);
//
//				time=2;
//			}

//						TreeSpawnerPoint1.GetComponent<MeshRenderer> ().enabled = true;
//						TreeSpawnerPoint1.GetComponent<BoxCollider> ().enabled = true;
//
//						TreeSpawnerPoint2.GetComponent<MeshRenderer> ().enabled = true;
//						TreeSpawnerPoint2.GetComponent<BoxCollider> ().enabled = true;
//
//						TreeSpawnerPoint3.GetComponent<MeshRenderer> ().enabled = true;
//			     		TreeSpawnerPoint3.GetComponent<BoxCollider> ().enabled = true;
		}
	}	
//	IEnumerator Wait3Tree2() {
//		
//		TreeSpawnerPoint1 = GameObject.Find ("TreeSpawnerPoint1");
//		TreeSpawnerPoint1.GetComponent<MeshRenderer>().enabled = false;
//		TreeSpawnerPoint1.GetComponent<BoxCollider>().enabled = false;
//		
//		TreeSpawnerPoint2 = GameObject.Find ("TreeSpawnerPoint2");
//		TreeSpawnerPoint2.GetComponent<MeshRenderer>().enabled = false;
//		TreeSpawnerPoint2.GetComponent<BoxCollider>().enabled = false;
//		
//		TreeSpawnerPoint3 = GameObject.Find ("TreeSpawnerPoint3");
//		TreeSpawnerPoint3.GetComponent<MeshRenderer>().enabled = false;
//		TreeSpawnerPoint3.GetComponent<BoxCollider>().enabled = false;
//		
//		yield return new WaitForSeconds(3f);
//		
//		TreeSpawnerPoint1.GetComponent<MeshRenderer>().enabled = true;
//		TreeSpawnerPoint1.GetComponent<BoxCollider>().enabled = true;
//		
//		TreeSpawnerPoint2.GetComponent<MeshRenderer>().enabled = true;
//		TreeSpawnerPoint2.GetComponent<BoxCollider>().enabled = true;
//		
//		TreeSpawnerPoint3.GetComponent<MeshRenderer>().enabled = true;
//		TreeSpawnerPoint3.GetComponent<BoxCollider>().enabled = true;
//		
//	}	
//	IEnumerator Wait3Tree3() {
//		
//		TreeSpawnerPoint1 = GameObject.Find ("TreeSpawnerPoint1");
//		TreeSpawnerPoint1.GetComponent<MeshRenderer>().enabled = false;
//		TreeSpawnerPoint1.GetComponent<BoxCollider>().enabled = false;
//		
//		TreeSpawnerPoint2 = GameObject.Find ("TreeSpawnerPoint2");
//		TreeSpawnerPoint2.GetComponent<MeshRenderer>().enabled = false;
//		TreeSpawnerPoint2.GetComponent<BoxCollider>().enabled = false;
//		
//		TreeSpawnerPoint3 = GameObject.Find ("TreeSpawnerPoint3");
//		TreeSpawnerPoint3.GetComponent<MeshRenderer>().enabled = false;
//		TreeSpawnerPoint3.GetComponent<BoxCollider>().enabled = false;
//		
//		yield return new WaitForSeconds(3f);
//		
//		TreeSpawnerPoint1.GetComponent<MeshRenderer>().enabled = true;
//		TreeSpawnerPoint1.GetComponent<BoxCollider>().enabled = true;
//		
//		TreeSpawnerPoint2.GetComponent<MeshRenderer>().enabled = true;
//		TreeSpawnerPoint2.GetComponent<BoxCollider>().enabled = true;
//		
//		TreeSpawnerPoint3.GetComponent<MeshRenderer>().enabled = true;
//		TreeSpawnerPoint3.GetComponent<BoxCollider>().enabled = true;
//	}

}
