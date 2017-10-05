using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FieldController : MonoBehaviour {

	public Button tryAgainButton;
	public Button uploadScoreButton;
	public InputField PlayerName;
	// Use this for initialization
	void Start () {

		tryAgainButton.GetComponent<Button> ();
		uploadScoreButton.GetComponent<Button> ();
		PlayerName.GetComponent<InputField> ();

		tryAgainButton.transform.localScale = Vector3.zero;
		uploadScoreButton.transform.localScale = Vector3.zero;
		PlayerName.transform.localScale = Vector3.zero;

	}
	
	// Update is called once per frame
	void Update () {

		if (Movement.GameComplete) {

			tryAgainButton.transform.localScale = Vector3.one;

			if (Movement.recordedTime > 0) {
				uploadScoreButton.transform.localScale = Vector3.one;
				PlayerName.transform.localScale = Vector3.one;
			}
		}

	
	}
}
