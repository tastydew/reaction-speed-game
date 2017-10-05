using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	public Button start;
	public string Level;
	// Use this for initialization
	void Start () {
	 
		start.onClick.AddListener (() => {
			StartButtonClick ();
		});
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void StartButtonClick(){

		SceneManager.LoadScene(Level);
	}
}
