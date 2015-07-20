using UnityEngine;
using System.Collections;

public class PowerUpSpawner : MonoBehaviour {

	private float nextSpawnTime;

	public GameObject cubie;

	public GameObject tongue;
	// Use this for initialization

	void Start(){


	}

	void Spawn () {
	
		Instantiate(cubie, transform.position, transform.rotation);

	}
	
	// Update is called once per frame
	void Update () {
	
		if(tongue.gameObject.GetComponent<TongueKiller>().count > 10){

			if (Time.time > nextSpawnTime) {

				Spawn();

				nextSpawnTime = Time.time + Random.Range(50,80); 
			}
		}
	}
}
