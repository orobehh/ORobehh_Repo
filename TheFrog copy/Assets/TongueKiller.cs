using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TongueKiller : MonoBehaviour {

	public Text Textie;
	
	public Text hScore;

//	public int highScore = 0;

	public int count;

	public AudioClip punchsound;
	public AudioClip ouch;
	public AudioClip StingSound;
	public AudioClip Woo;

	GameObject cam;

	GameObject frog;

	public GameObject RushText;

	
	void Start(){



		cam = GameObject.Find ("Main Camera");
		frog = GameObject.Find ("Frog");

	}
	void Update() {


		
		if(Input.GetKeyDown(KeyCode.Escape)){

			Application.Quit();

		}
		Textie.text = count.ToString();
		
		//hScore.text = highScore.ToString ();
	//	GUITTEXT.text = count.ToString ();

	}

	public void ouchie () {

		AudioSource.PlayClipAtPoint(ouch, transform.position);
	}

	void re(){

		Application.LoadLevel (Application.loadedLevel);


	}

	public void rere(){

		Invoke ("re", 3);

	}

	public void ouchiDelay(){
	
		Invoke ("ouchie",0.3f);

	}



	// Use this for initialization
	void OnTriggerEnter2D (Collider2D col) {
	
		if(col.gameObject.tag == "Fly" ){

			//GetComponent<FroggyControl>().baktoIDLE();

			AudioSource.PlayClipAtPoint(punchsound, transform.position);

			col.gameObject.GetComponent<Animator>().SetTrigger("Die");

			cam.GetComponent<Shakescript>().ShakeShake();

			col.GetComponent<BoxCollider2D>().enabled=false;

			col.GetComponent<AudioSource>().enabled = false;

			Destroy(col.gameObject, 0.6f);

			count++;


		}

		if(col.gameObject.tag == "Bee" ){

			AudioSource.PlayClipAtPoint(StingSound, transform.position);

			frog.gameObject.GetComponent<FroggyControl>().deathtrigger();
			

			frog.gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2(0, 350));

			frog.gameObject.GetComponent<BoxCollider2D>().enabled = true;

			Invoke ("ouchie",0.3f);

			frog.gameObject.GetComponent<PolygonCollider2D>().enabled = false;


			frog.gameObject.GetComponent<FroggyControl>().enabled = false;

			Invoke ("re", 3);
			
		}

		if (col.gameObject.tag == "PowerUp") {

			AudioSource.PlayClipAtPoint(Woo, transform.position);

			cam.gameObject.GetComponent<SpawnFlies>().SpawnPowerUp();

			Destroy (col.gameObject, 0.2f);

			RushText.gameObject.SetActive(true);
			
			Invoke ("turnoffrush" , 3);
			
		}

			

	
	}

	void turnoffrush (){

		RushText.gameObject.SetActive (false);
	}
	

}
