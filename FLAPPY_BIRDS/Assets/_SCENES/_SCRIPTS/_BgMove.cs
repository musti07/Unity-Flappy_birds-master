using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _BgMove : MonoBehaviour {
	public float speed;
	public _MoveUp movScript;


	private bool isdead = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (movScript.isdead != true && movScript.gameStarted) //isdead
		{
			transform.Translate (-1 * Time.deltaTime * speed, 0, 0);
		} 

	}
	 
}
