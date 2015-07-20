using UnityEngine;
using System.Collections;

public class PiranhaController : MonoBehaviour {


	private Animator anim;
	public float nextShot = 3.5f;
	public float shotInterval = 5.2f;

	public GameObject Tongue;

	public string [] PiraAnimTriggers;

	
	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {
	
		int Piras = Random.Range(0,PiraAnimTriggers.Length);
		string TheRandomPira = PiraAnimTriggers[Piras];


		if(Tongue.gameObject.GetComponent<TongueKiller>().count > 5){

			if (Time.time > nextShot) {


				anim.SetTrigger(TheRandomPira);


				nextShot = Time.time + Random.Range(10,20); 

			}
		}

	}
}
