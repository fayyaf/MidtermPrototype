using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float time; // assign in inspector
	

	// Update is called once per frame
	void Update ()
	{
		string textBuffer = "Time Remaining To Grab Soup: ";

		time -= Time.deltaTime;

		int minutes = (int)time / 60;
		int seconds = (int)time % 60;

		if (time > 0)
		{
			// text displayed
			textBuffer += (minutes + ":" + seconds.ToString ("D2")); 
		}

		if (time < 0)
		{
			// debug
			Debug.Log ("Bad ending level change");
			Application.LoadLevel ("badending");
		}

		if (time > 0 && TriggerPickup.winstate)
		{
			// debug
			Debug.Log ("Good ending level change");
			Application.LoadLevel ("goodending");
		}

		GetComponent<Text>().text = textBuffer;
	}
}