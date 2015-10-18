using UnityEngine;
using System.Collections;

public class DifficultyChange : MonoBehaviour {

	public GameObject easy;
	public GameObject medium;

	// Use this for initialization
	void Start ()
	{

		if (IntroMenuStart.easy)
		{
			medium.SetActive (false);
			easy.SetActive (true); // deactivate game object
		}

		if (IntroMenuStart.medium)
		{
			easy.SetActive (false);
			medium.SetActive (true);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
