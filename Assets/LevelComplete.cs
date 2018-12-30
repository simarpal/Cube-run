using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {
	public void LoadNextLevel(){
		var buildIndex = SceneManager.GetActiveScene().buildIndex;
		Debug.Log(buildIndex);
		if(buildIndex < 3){
			SceneManager.LoadScene(buildIndex + 1);
		}
		else{
			Application.Quit();
		}
	}
}
