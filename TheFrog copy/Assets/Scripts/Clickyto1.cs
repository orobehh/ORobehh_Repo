using UnityEngine;
using System.Collections;

public class Clickyto1: MonoBehaviour 
{

	public GameObject ObjectsToKill;



	void Start () {

		Time.timeScale = 1;
		Invoke ("KIllobj", 10);

	}
	public void NextLevelButton(int index)
	{
		Application.LoadLevel(index);
	}
	
	public void NextLevelButton(string levelName)
	{
		Application.LoadLevel(levelName);
	}

	public void pause (){
		Time.timeScale = 0;

	}

	public void resume(){
		Time.timeScale = 1;

	}

	public void KIllobj() {

		ObjectsToKill.gameObject.SetActive (false);

	}

		
	}




	
	
		
		
			
