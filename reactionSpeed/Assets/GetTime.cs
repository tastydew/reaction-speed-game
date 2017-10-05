using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetTime : MonoBehaviour {

	private Text text;
	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();
		text.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		if (Movement.isGreen) {
			text.text = string.Format ("{0:#0.0000}", Movement.recordedTime);
		}
	}
}
