using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	public Transform player;
	public Text score;
	
	// Update is called once per frame
	void Update () {
		var buildIndex = SceneManager.GetActiveScene().buildIndex;
		score.text = (buildIndex*565 + player.position.z).ToString("0");
	}
}
