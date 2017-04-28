using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public static int highScore;
	public Text highScoreText;

	// Use this for initialization
	void Start () {
		highScoreText.text = "High Score: " + highScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickPlay () {
		Application.LoadLevel ("Game");
	}

	public void OnClickHighScore () {
		
	}
}
