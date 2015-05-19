using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int NumBGPanels = 5 ;

	float treeMax = 0.5f;
	float treeMin = -1f;


	//x morm premaknat za 25.339f; da pride v nasledni almost perfect loop 42.226
	
	void Start() {
		GameObject[] trees = GameObject.FindGameObjectsWithTag("Tree");
		
//		foreach(GameObject tree in trees) {
//			Vector3 pos = tree.transform.position;
//			pos.y = Random.Range(treeMin, treeMax);
//			tree.transform.position = pos;
//		}
	}


	void OnTriggerEnter2D(Collider2D collider)
	{


//		float widthOfBGObject = ((BoxCollider2D)collider).size.x;
		
		Vector3 pos = collider.transform.position;
		
		pos.x += 33.7863f;

		if(collider.tag == "Tree") {

			pos.y = Random.Range(treeMin, treeMax);
		}
		collider.transform.position = pos;






	}
}
