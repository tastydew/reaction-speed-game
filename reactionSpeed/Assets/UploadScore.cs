using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UploadScore : MonoBehaviour {

	//player data and upload url
	private string postDataURL = "http://tastydew.com/rsgame/submitscorev3.php?";
	private string playername;
	private string score;

	//player data fields
	public Text playerScoreText;
	public InputField PlayerNameField;

	//upload score button
	public Button uploadScoreButton;
	// Use this for initialization
	void Start () {

		PlayerNameField.GetComponent<InputField> ();
		uploadScoreButton.GetComponent<Button> ();
		playerScoreText.GetComponent<Text> ();
		uploadScoreButton.transform.localScale = Vector3.zero;
		uploadScoreButton.onClick.AddListener ( () => { ButtonClick(); } );
	}

	void ButtonClick(){

		if (PlayerNameField.text.ToString () == "") {

		} else {

			Debug.Log (PlayerNameField.text);
			Debug.Log (playerScoreText.text);
			playername = PlayerNameField.text;
			score = playerScoreText.text;

			if (playerScoreText.text == "") {
				score = "CHEATER";
			}
			StartCoroutine (SendScore (playername, score));
			StartCoroutine (Wait ());
			Application.OpenURL ("http://tastydew.com/rsgame/");
			uploadScoreButton.enabled = false;
		}


	}

	IEnumerator Wait(){
	
		yield return new WaitForSeconds (2);
	}

	IEnumerator SendScore(string name, string score){

		string post_url = postDataURL + "name=" + WWW.EscapeURL (name) + "&data=" + score;

		WWW postData = new WWW (post_url);
		Debug.Log (post_url);
		yield return postData;

		if (postData.error != null) {
		
			playerScoreText.text = "Error Uploading :(";
			Debug.Log (postData.error);

		
		} else {
			uploadScoreButton.transform.localScale = Vector3.zero;
			playerScoreText.color = Color.green;
			playerScoreText.text = "Uploaded!";
		}

	}

}
