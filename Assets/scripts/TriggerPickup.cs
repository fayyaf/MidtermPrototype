using UnityEngine;
using System.Collections;

public class TriggerPickup : MonoBehaviour {

	public Transform parent;
	private Transform currentlyHolding;
	public static bool winstate;

	void Start()
	{
		winstate = false;
	}

	void Update()
	{
		transform.position = parent.position;

		if (Input.GetKeyDown (KeyCode.J))
		{
			if (currentlyHolding != null)
			{
				currentlyHolding.parent = null;
				currentlyHolding = null;
			}
		}
	}


	void OnTriggerStay (Collider activator)
	{
		// parenting the pickup to the player
		if (activator.tag == "Pickup" && Input.GetKeyDown(KeyCode.F))
		{
			//Debug.Log ("picking up");
			activator.transform.SetParent (transform);
			if (currentlyHolding != null) // if player is holding an object
			{
				currentlyHolding.parent = null;
			}
		

			currentlyHolding = activator.transform;

			if (currentlyHolding.name == "Goal")
			{
				winstate = true;
			}
		}

	}
}
