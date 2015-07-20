using UnityEngine;
using System.Collections;

public class Destroyall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D	 (Collider2D col) {
	
		Destroy (col.gameObject);

	}
}
