using UnityEngine;
using System.Collections;

public class winner : MonoBehaviour
{
	//.20 add a reference to the style
	public GUISkin style;
	
	//18.added gui to menu controller
	void OnGUI ()
	{
		
		//21. add the skin to the gui
		GUI.skin = style;
		
		//19.create the name of the game in the middle of the screen
		//GUI.Label (new Rect (Screen.width / 2 - 125f, Screen.height / 2 - 50f, 250f, 100f), "Asteroid Attack");

		//25.load the main game 
		if (GUI.Button (new Rect (Screen.width / 2 + 100f, Screen.height / 3 + 0f, 100f, 50f), "Play Again")) {
			//26. load the main scene (which is 1 in the build settings)
			Application.LoadLevel (2);
		}
		//25.load the main game 
		if (GUI.Button (new Rect (Screen.width / 2 + 112f, Screen.height / 2 + 0f, 75f, 50f), "Quit")) {
			//26. load the main scene (which is 1 in the build settings)
			Application.Quit ();

		}
	}
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}