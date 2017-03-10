using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour {

	public GameObject movePlatform;

	private void OnTriggerEnter(Collider col){
		Debug.Log ("Enter");
		movePlatform.SetActive(true);

	}


}
