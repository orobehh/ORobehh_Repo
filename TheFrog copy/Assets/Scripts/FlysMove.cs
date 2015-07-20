using UnityEngine;
using System.Collections;

public class FlysMove : MonoBehaviour {

	public float speed;
	private Animator anim;

	// Use this for initialization
	void Start () {

		Destroy (gameObject, 30);
	
		speed = Random.Range (-0.5f,-2f);

		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {



		transform.Translate (speed * Time.deltaTime, 0, 0);

	}

	public void triggerdeath() {


		anim.SetTrigger ("Die");


	} 

}
