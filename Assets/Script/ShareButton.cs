using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShareButton : MonoBehaviour {

	public Material[] material;
	public Renderer rend;
	public GameObject movePlatform;
	public GameObject movePlatform2;
	private int index = 1;

	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}

	public void OnMouseDown(){
		if(material.Length == 0 ){
			return;
		}

		if(Input.GetMouseButtonDown(0)){
			index += 1;
			if(index == material.Length + 1){
				index = 1;
			}
			print (index);
			rend.sharedMaterial = material [index - 1];
			if (index == 1) {
				Debug.Log ("not shared");
				movePlatform.SetActive (false);
				movePlatform2.SetActive (true);
			} else {
				Debug.Log ("shared");
				movePlatform.SetActive (true);
				movePlatform2.SetActive (false);
			}
		}
	}
}
