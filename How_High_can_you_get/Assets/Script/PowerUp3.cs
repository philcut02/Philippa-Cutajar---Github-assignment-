using UnityEngine;
using System.Collections;

public class PowerUp3 : MonoBehaviour
{

	ScoreManager ScoreLabel ;

	void Awake ()
	{
		ScoreLabel = GameObject.FindGameObjectWithTag ("sc_manager").GetComponent<ScoreManager> ();
	}
	// Use this for initialization
	void Start ()
	{
	
	}

	void OnMouseDown ()
	{
		ScoreLabel.score += 6;
		Destroy (this.gameObject);

	}



}

