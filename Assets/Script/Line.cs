using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

	void OnMouseDown(){
		Debug.Log ("Line pressed");
		Application.OpenURL ("http://line.me/ti/p/~mhakim96");
	}
}
