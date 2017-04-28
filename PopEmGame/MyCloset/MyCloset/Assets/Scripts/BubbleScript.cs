using UnityEngine;
using System.Collections;

public class BubbleScript : MonoBehaviour {

	public float speed;
	public float startingXPosition;
	public float startingYPosition;
	public ParticleSystem explosion;

	// Use this for initialization
	void Start () {

		speed = Random.Range (0.02f, 0.03f);
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(transform.position.x, transform.position.y - speed);

		if (transform.position.y <= -5.5f) {
			GameManager.gameOver = true;
		}
	}
		
	void OnMouseDown () {
		Instantiate(explosion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
		startingXPosition = Random.Range(-2f, 2f);
		Debug.Log (startingXPosition);
		startingYPosition = Random.Range (7f, 25f);
		transform.position = new Vector2 (startingXPosition, startingYPosition);
		speed += 0.005f;
		GameManager.score++;
	}
}
