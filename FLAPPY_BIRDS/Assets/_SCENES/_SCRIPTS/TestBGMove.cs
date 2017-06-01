using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestBGMove : MonoBehaviour {
	public Vector3 reposition;
	public float speed;

	private float x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-1 * Time.deltaTime * speed , 0 , 0);

		if (transform.position.x <= -15.15537f) {
			transform.position =  reposition;
		}
	}
		


}
