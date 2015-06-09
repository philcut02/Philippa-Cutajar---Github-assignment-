using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
	
		void OnCollisionEnter2D (Collision2D col)
		{
	
		if (col.rigidbody.gameObject.tag == "boxes") {
			Application.LoadLevel ("gameover");

		}

	}

}