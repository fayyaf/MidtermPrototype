using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	public float distance = 5f;
	public Transform player;
	public GameObject cube;
	public Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.E))
		{
			distance = Vector3.Distance(player.position, transform.position);

			if (distance < 0.2f)
			{
				rb.isKinematic = true;
				rb.detectCollisions = false;

				// parent box to player and set box to kinematic
				//Sets "newParent" as the new parent of the crate GameObject.
				cube.transform.SetParent(player);
				
				//Same as above, except this makes the player keep its local orientation rather than its global orientation.
				cube.transform.SetParent(player, false);
			}

		}
		else
		{
			rb.isKinematic = false;
			rb.detectCollisions = true;
			transform.parent = null; // drops the box
		}

		/*
		 * 
		 * if (player pressed space)
    		(check distance between box and player)
        		(if distance < 2, then parent box to player and set box to kinematic)

		* if (player released space)
   			(unparent box, set box to not kinematic(
		 * 
		 * 
		 * 
		 * */
	
	}
}
