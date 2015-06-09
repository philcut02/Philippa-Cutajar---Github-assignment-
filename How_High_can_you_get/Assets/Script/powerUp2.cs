using UnityEngine;
using System.Collections;

public class powerUp2 : MonoBehaviour {
	
	
	bool hit = false;
	
	void OnMouseDown()
	{
		hit = true;
	}
	
	
	IEnumerator speedTime()
	{
		
		Time.timeScale = 4.0f;
		yield return new WaitForSeconds (3.0f);
		
		Time.timeScale = 1.0f;
		
	}
	
	IEnumerator selfDestruct()
	{
		yield return new WaitForSeconds (3f);
		Destroy (this.gameObject);
		Debug.Log ("2");
	}
	
	
	
	
	
	void Update()
	{
		if (hit) {
			GetComponent<Renderer>().enabled = false;
			GetComponent<BoxCollider2D>().enabled = false;
			
			StartCoroutine ("speedTime");
			StartCoroutine ("selfDestruct");
		}
	}
	
	
}