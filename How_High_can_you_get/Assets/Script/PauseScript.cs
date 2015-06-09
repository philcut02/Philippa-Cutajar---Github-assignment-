using UnityEngine;
using System.Collections;

public class PauseScript: MonoBehaviour {
	
	public GUISkin style;
	
	//18.added gui to menu controller
	void OnGUI ()
	{
		
		//21. add the skin to the gui
		GUI.skin = style;
		
		if (GUI.Button (new Rect (Screen.width / 2 + -650f, Screen.height / 7 + 0f, 75f, 50f), "Pause")) {
			//26. load the main scene (which is 1 in the build settings)


		
			
			Time.timeScale = 1;
		}

		if (GUI.Button (new Rect (Screen.width / 2 +-650f, Screen.height / 5 + 20f, 75f, 50f), "Continue")) {
			//26. load the main scene (which is 1 in the build settings)
		
		
		
	
			Time.timeScale = 1;

		}
		if (GUI.Button (new Rect (Screen.width / 2 + 550f, Screen.height / 7 + 20f, 75f, 50f), "Quit")) {
			//26. load the main scene (which is 1 in the build settings)
			Application.Quit ();
			
		}

	}
	}
