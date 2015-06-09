using UnityEngine;
using System.Collections;

public class boxLauncher : MonoBehaviour {

	public GameObject [] boxPrefabs;

	public float fireDelay =3f;
	public float nextFire = 1f;

	public float fireVelocity = 10f;

	void FixedUpdate () {
		nextFire -= Time.deltaTime;

		if (nextFire <= 0) {
			//spawn a new box
			nextFire = fireDelay;

			GameObject boxGO = (GameObject)Instantiate(
				boxPrefabs [Random.Range (0, boxPrefabs.Length)],
				             transform.position,
				             transform.rotation);

			boxGO.rigidbody2D.velocity = transform.rotation * new Vector2 (0, fireVelocity);

		}
	}
}

