using UnityEngine;
using System.Collections;

public class MouseManager : MonoBehaviour {



	float dragSpeed = 10f;

	Rigidbody2D grabbedObject = null; 

	Vector2 mousePos2D;


	void Start()
	{

	}


	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButton (0)) {
		
		
			Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		

			mousePos2D = new Vector2(mouseWorldPos3D.x, mouseWorldPos3D.y);

		

			Vector2 dir = Vector2.zero;

			RaycastHit2D hit = Physics2D.Raycast (mousePos2D, dir);

			if (hit != null && hit.collider != null) {
				if (hit.collider.rigidbody2D != null) {
					grabbedObject = hit.collider.rigidbody2D;
					grabbedObject.gravityScale = 0;
				

				}
			}
		}
		if (Input.GetMouseButtonUp (0) && grabbedObject != null) {
			grabbedObject.gravityScale = 1;
			grabbedObject = null;

		}
	}

	LineRenderer thisDragLine;

	void FixedUpdate () {
		if (grabbedObject != null) {
			// move the object with the mouse
		
			//grabbedObject.position = mousePos2D;
			Vector2 dir = mousePos2D - grabbedObject.position;

			dir *= dragSpeed;

			grabbedObject.velocity = dir;

			thisDragLine = GameObject.FindGameObjectWithTag("theline").GetComponent<LineRenderer>();
			thisDragLine.enabled = true;	
				
			thisDragLine.SetPosition(0, new Vector3 (grabbedObject.position.x, grabbedObject.position.y, 0));
			thisDragLine.SetPosition(1, new Vector3(mousePos2D.x,mousePos2D.y, 0));
				
				
			}


		}

	void OnBecameInvisible()
	{
		if (thisDragLine != null) {
			thisDragLine.enabled = false;
		}
	}
}

