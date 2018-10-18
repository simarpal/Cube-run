using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnded = false;
	public GameObject completeLevelUI;

	public void CompleteLevel(){
		completeLevelUI.SetActive(true);
	}

	public void EndGame(string reason){
		if(gameEnded == false){
			gameEnded = true;
			if(reason == "falling"){
				Invoke("RestartGame", 0.1f);
			}else{
				Invoke("RestartGame", 1.5f);
			}
		}
	}

	public void RestartGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
