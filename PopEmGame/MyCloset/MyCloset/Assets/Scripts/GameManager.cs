using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	GameObject bubble;
	public static bool gameOver;
	public static int score;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	// Update is called once per frame
	void Update () {

		scoreText.text = "Score: " + score;

		if (gameOver) {
			gameOver = false;

			if (score > MenuManager.highScore) {
				MenuManager.highScore = score;
			}

			score = 0;
			Application.LoadLevel ("Main");
		}
	}
}
