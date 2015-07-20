using UnityEngine;
using System.Collections;

public class FroggyControl : MonoBehaviour {

	public bool jump = false;
	public bool Tongue = false;

	public float jumpForce = 1000f;	
	public Transform groundCheck;
	private bool grounded = false;
	private Animator anim;
	public AudioClip JumpClips;
	public AudioClip TongueWhip;

	public AudioClip chew;

	public GameObject tongie;


	// Use this for initialization
	void Start () {
	

		Application.targetFrameRate = 60;
		groundCheck = transform.Find("groundCheck");
		anim = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {



		if(Input.GetKeyDown(KeyCode.Escape)){
			
			Application.Quit();
			
		}

		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));
		if (Input.GetKeyDown (KeyCode.Space) && grounded)
			
			jump = true;



			if (Input.GetKeyDown (KeyCode.X) && grounded)

				Tongue = true;
		}

	void FixedUpdate(){


		
		
		if(jump){
			
			anim.SetTrigger ("Bounce");
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce * Time.deltaTime));

//			Invoke ("jumpdelay",0.1f);
//			Invoke("zeroJumpForce",0.1f);
//			Invoke ("jumpforcie",0.3f);
			jump = false;
			GetComponent<AudioSource>().PlayOneShot(JumpClips);
			
		}



		if(Tongue){
			
			anim.SetTrigger ("Tongue");
			GetComponent<AudioSource>().PlayOneShot(TongueWhip);
			Tongue = false;

		}

	
	}

	void Jumping(){
		if (grounded) {
			jump = true;
		}
	}

	void TongueZ(){
		//if (grounded) {
			Tongue = true;
		//}
	}


	void jumpdelay(){

		GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce * Time.deltaTime));


	}
	void zeroJumpForce (){

		jumpForce = 0;
	}

	void jumpforcie(){

		jumpForce = 13000;
	}



	public void deathtrigger(){

		anim.SetTrigger ("Death");
	}


	void OnTriggerEnter2D (Collider2D Other) {


		if(Other.gameObject.tag == "Piranha"){


			if(grounded){

				GetComponent<Rigidbody2D>().AddForce (new Vector2(0f, 350f));
			}

			GetComponent<BoxCollider2D>().enabled = true;

			tongie.gameObject.GetComponent<TongueKiller>().ouchiDelay();

			GetComponent<PolygonCollider2D>().enabled = false;

			AudioSource.PlayClipAtPoint(chew, transform.position);

			GetComponent<FroggyControl>().enabled = false;

			tongie.gameObject.GetComponent<TongueKiller>().rere();

			deathtrigger();


		}

	} 

}
