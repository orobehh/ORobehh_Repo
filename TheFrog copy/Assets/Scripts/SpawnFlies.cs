using UnityEngine;
using System.Collections;

public class SpawnFlies : MonoBehaviour {

	public float nextShot = 3.5f;
	public float shotInterval = 5.2f;

	public float NextBeeShot = 3.5f;
	public float BeeshotInterval = 5.2f;


	public GameObject [] Fly_1;

	public GameObject PowerUp;

	public GameObject tongie;

	public GameObject bee;
	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextShot) {

			int spawnObjectIndex = Random.Range(0,Fly_1.Length);

			GameObject randPrefab = Fly_1[spawnObjectIndex];


			if(tongie.gameObject.GetComponent<TongueKiller>().count > 9 ){
				
				Vector3 possier = new Vector3(Random.Range(6, 6.3f),Random.Range(3, 4.2f), 0); 
				Instantiate (randPrefab , possier, Quaternion.identity);
				
			}

			Vector3 poss = new Vector3(Random.Range(6, 6.3f),Random.Range(3, 4.2f), 0); 
			Instantiate (randPrefab , poss, Quaternion.identity);
			nextShot = Time.time + shotInterval; 

		}

		if(tongie.gameObject.GetComponent<TongueKiller>().count > 3 ){

			shotInterval = 1.5f;


		}

		if (Time.time > NextBeeShot) {


		if(tongie.gameObject.GetComponent<TongueKiller>().count > 6 ){
			
			Vector3 possie = new Vector3(Random.Range(6, 6.3f),Random.Range(2, 4.2f), 0); 
			Instantiate (bee , possie, Quaternion.identity);
			
				NextBeeShot = Time.time + Random.Range (2,5); 

			
			}

		}



		
	
	}


	public void SpawnPowerUp(){

		Vector3 poss = new Vector3(Random.Range(6, 6.3f),Random.Range(3, 4.2f), 0); 
		Instantiate (PowerUp , poss, Quaternion.identity);


	}
}
