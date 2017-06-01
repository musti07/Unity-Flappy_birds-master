using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class My_LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void QuitGame()
	{
		Application.Quit ();
	}

	public void StartGame()
	{
		SceneManager.LoadScene("GAME_SCENE");
	}
}
