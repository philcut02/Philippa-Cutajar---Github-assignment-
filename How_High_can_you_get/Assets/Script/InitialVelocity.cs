using UnityEngine;
using System.Collections;

public class InitialVelocity : MonoBehaviour
{

	ScoreManager ScoreLabel ;
	public Vector3 initvel;
	public AudioClip boxSound;

	void Awake ()
	{
		ScoreLabel = GameObject.FindGameObjectWithTag ("sc_manager").GetComponent<ScoreManager> ();
	}
	// Use this for initialization
	void Start ()
	{
		this.rigidbody2D.velocity = initvel;


		Camera.main.GetComponent<AudioSource> ().PlayOneShot (boxSound);

	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.collider.gameObject.tag == "boxes") {
			//Debug.Log ("hit");
			ScoreLabel.score ++;
		}
	}
}