using UnityEngine;
using System.Collections;

public class GUIAspectRatioScale : MonoBehaviour {

	public Vector2 scaleOnRatio1= new Vector2(0.1f,0.1f);
	Transform myTrans;
	float widthheightRatio;

		// Use this for initialization
	void Start () {
	
		myTrans = this.transform;
		SetScale (scaleOnRatio1);

	}
	
	public void SetScale(Vector2 scale)
	{
		widthheightRatio = (float)Screen.width / Screen.height;

		if (scale == Vector2.zero)
						//Debug.Log ("Scale is zero");

		myTrans.localScale = new Vector3 (scale.x, widthheightRatio * scale.y, 1);
	}
}
