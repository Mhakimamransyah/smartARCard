using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
	public GameObject movePlatform;

	private void OnTriggerExit(Collider col){
		Debug.Log ("exit");
		movePlatform.SetActive (false);
	}
}
