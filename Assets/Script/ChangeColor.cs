using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	// Use this for initialization
	public Texture[] texture;
	public Renderer rend;

	private int index = 1;

	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}

	void OnMouseDown(){

		if(texture.Length == 0 ){
			return;
		}

		if(Input.GetMouseButtonDown(0)){
			index += 1;
			if(index == texture.Length + 1){
				index = 1;
			}

			print (index);
			rend.sharedMaterial.mainTexture = texture [index - 1];
		}

	}
}
