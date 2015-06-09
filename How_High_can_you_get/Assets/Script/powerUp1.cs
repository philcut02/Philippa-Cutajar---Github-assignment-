using UnityEngine;
using System.Collections;

public class powerUp1 : MonoBehaviour {


	bool hit = false;

	void OnMouseDown()
	{
		hit = true;
	}


	IEnumerator slowTime()
	{

			Time.timeScale = 0.2f;
		yield return new WaitForSeconds (1.0f);

		Time.timeScale = 1.0f;

	}

	IEnumerator selfDestruct()
	{
		yield return new WaitForSeconds (3f);
		Destroy (this.gameObject);
		Debug.Log ("1");
	}




	
	void Update()
	{
		if (hit) {
			GetComponent<Renderer>().enabled = false;
			GetComponent<BoxCollider2D>().enabled = false;

			StartCoroutine ("slowTime");
			StartCoroutine ("selfDestruct");
		}
	}


}

