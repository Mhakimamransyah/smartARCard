using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instagram : MonoBehaviour {
	void OnMouseDown(){
		Debug.Log ("ig pressed");
		Application.OpenURL ("https://www.instagram.com");
	}
}
