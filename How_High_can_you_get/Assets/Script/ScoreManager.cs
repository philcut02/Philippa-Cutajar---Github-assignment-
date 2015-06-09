using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {


	//24. create a public variable for the GUI skin
	public GUISkin style;


	//35. Declare a variable for the current time
	float currentTime;
	public int score;
	
	//36. Declare a variable for the start time
	float startTime;

	void Start () {

		startTime = Time.time;
	}
	string minutes;
	string seconds;

	void Update()
	{
		currentTime = Time.time;
		currentTime = currentTime - startTime;
	

		//42. After 30 seconds, in level 1, go to level 2
		if (currentTime > 30 && Application.loadedLevelName == "level 1") {
			//43. Load level 2
			Application.LoadLevel ("level 2");
		}
		if (currentTime > 40 && Application.loadedLevelName == "level 2") {
			//43. Load level 2
			Application.LoadLevel ("level 3");
		}
		if (currentTime > 40 && Application.loadedLevelName == "level 3") {
			//43. Load level 2
			Application.LoadLevel ("winner");
		}
	}
void OnGUI ()
{
	
	//39. format minutes
	 minutes = Mathf.Floor (currentTime / 60).ToString ("00");
	//40. format seconds
	 seconds = Mathf.Floor (currentTime % 60).ToString ("00");
	
	
	//28. apply the style sheet	
	GUI.skin = style;
	
	string ScoreLabel = "score ";

	//41. output the minutes : seconds
	GUI.Label (new Rect (10f, 10f, 150f, 30f), minutes + ":" + seconds);
	
	//44. show the level.  show the scene name on screen
	GUI.Label (new Rect (10f, 40f, 150f, 30f), Application.loadedLevelName);
	

	GUI.Label (new Rect (10f, 70f, 150, 20), ScoreLabel + score);
	}
}
