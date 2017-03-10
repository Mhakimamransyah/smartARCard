using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facebook : MonoBehaviour {

	void OnMouseDown(){
		Debug.Log ("facebook pressed");
		Application.OpenURL ("https://www.facebook.com");
	}
}
