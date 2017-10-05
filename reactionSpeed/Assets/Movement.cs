using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

	private bool gameHasFocus;
	public static bool GameComplete;
	public static float recordedTime = 0f;
	public static bool isGreen = false;
	public float speed;
	private Rigidbody2D circle;
	public Sprite[] sprites;
	private float triggerTime;
	private float startTime = 0;
	private bool mouseInBounds;
	private Rect screenSize;

	// Use this for initialization
	void Start () {

		isGreen = false;
		screenSize = new Rect (0, 0, Screen.width, Screen.height);
		startTime = 0;
		recordedTime = 0;
		GameComplete = false;
		triggerTime = Random.Range (3, 30);
		circle = GetComponent<Rigidbody2D> ();
		circle.velocity = new Vector2 (speed * Time.deltaTime, speed * Time.deltaTime);

	}
	
	// Update is called once per frame
	void Update () {

		startTime += Time.deltaTime;
		mouseInBounds = screenSize.Contains (Input.mousePosition);

		if (!mouseInBounds) {
			if (!GameComplete) {
				recordedTime += 1.999f;
				triggerTime = startTime;
			}
		}
			
		if (startTime >= triggerTime) {
			this.GetComponent<SpriteRenderer> ().sprite = sprites [1];
			recordedTime += Time.deltaTime;
			getReactionSpeed ();
		} else if (startTime <= triggerTime && Input.GetKeyDown (KeyCode.Space)) {

			GameComplete = true;
			circle.velocity = Vector2.zero;
			startTime = -100000;
			recordedTime = -1;
		
		}

	}

	void getReactionSpeed(){
		    isGreen = true;
		if (Input.GetKeyDown (KeyCode.Space)) {
			isGreen = false;
			startTime = -100000;
			circle.velocity = Vector2.zero;
			GameComplete = true;

		} else if (Input.GetKeyDown (KeyCode.LeftWindows) || Input.GetKeyDown(KeyCode.RightWindows)) {

			recordedTime += 99.99f;
		}

	}
}
