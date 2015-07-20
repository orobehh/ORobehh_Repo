using UnityEngine;
using System.Collections;

public class Shakescript : MonoBehaviour {

	private Animator anim;

	public string [] shakes;

	void Start () {

		anim = GetComponent<Animator>();

	}

	void Update(){



	}



	public void ShakeShake () {
	
		int Shakesies = Random.Range(0,shakes.Length);
		string theRandomshake = shakes[Shakesies];

		anim.SetTrigger (theRandomshake);
	}
	

}
