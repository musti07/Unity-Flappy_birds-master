using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class _MoveUp : MonoBehaviour {
	public Vector2 myVec;
	public Rigidbody2D rbd;
	public float myforce;
	public Animator myAnim;
	public AudioSource audioJump;
	public AudioSource audioDead;
	public AudioSource audioHurt;
	public AudioSource audioCoinUp;
	public Text scoreText;
	public int scoreCount;

	public bool gameStarted = false;

	public bool isdead = false;
	// Use this for initialization
	void Start ()
	{
		
	}



	// Update is called once per frame
	void Update ()
		{
		if (Input.GetMouseButton (0) && isdead != true)
			{
			gameStarted = true;
			rbd.simulated = true;
			rbd.AddForce (Vector2.up * myforce, ForceMode2D.Impulse);
			audioJump.Play ();

			}
		}// End Update
		

	public void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "kill") {
			audioDead.Play ();
			myAnim.SetTrigger ("TrigDead");
			isdead = true;
			StartCoroutine (GameOverE(2));
		} 
		else if (coll.gameObject.tag == "noKill") 
		{

			print ("asaskaskas");
		}

	}

	public void OnTriggerEnter2D(Collider2D coll)
	{


		if (coll.gameObject.tag == "scoreTrig")
		{
			scoreCount++;
			scoreText.text = "SCORE- " + scoreCount;
			audioCoinUp.Play ();
		}
		else if (coll.gameObject.tag =="Hurt")
		{
			myAnim.SetTrigger ("TrigHurt");
			audioHurt.Play ();
		}
			
	}
		
	IEnumerator GameOverE(float time)
	{
		yield return new WaitForSeconds (time);
		SceneManager.LoadScene (1); 
	}
}
