using UnityEngine;
using System.Collections;

public class TurnOffRUSH : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Invoke ("TurnOff",3);

	}
	
	// Update is called once per frame
	void TurnOff () {
	
		gameObject.SetActive (false);

	}
}
