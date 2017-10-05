using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	public Button restartButton;
	// Use this for initialization
	void Start () {

		restartButton.GetComponent<Button> ();
		restartButton.onClick.AddListener ( () => { ButtonClick(); } );
	}

	void ButtonClick(){

		SceneManager.UnloadScene ("Level01");
		SceneManager.LoadScene ("Level01");

	}
}
