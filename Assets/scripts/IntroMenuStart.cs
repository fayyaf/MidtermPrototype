using UnityEngine;
using System.Collections;

public class IntroMenuStart : MonoBehaviour {

	// use the "static" keyword to make something
	// persist in code instead of a scene
	public static bool easy = false;
	public static bool medium = false;
	
	void Start()
	{
		easy = false; // reset manually because static will persist even if game restarts
		medium = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		// if player presses Space
		if (Input.GetKeyDown (KeyCode.E))
		{
			easy = true; // begin the nightmare // use of static makes sure unity remembers it's true
			// then change to the actual "game" scene
			Application.LoadLevel("prototype01"); // Application.LoadLevel("myGameScene");
		}

		if (Input.GetKeyDown (KeyCode.M))
		{
			medium = true; // begin the nightmare // use of static makes sure unity remembers it's true
			// then change to the actual "game" scene
			Application.LoadLevel("prototype01"); // Application.LoadLevel("myGameScene");
		}

	}
}
