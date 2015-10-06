using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	public float distance = 10f;
	public Transform player;
	public bool isKinematic;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		distance = Vector3.Distance(player.position, transform.position);
		
		if (Input.GetKey(KeyCode.Space) && distance < 2f)
		{

		}

		if (Input.GetKeyDown (KeyCode.Space))
		{

		}
		else
		{
			transform.parent = null;
		}

		/*
		 * if (player pressed space)
    (check distance between box and player)
        (if distance < 2, then parent box to player and set box to kinematic)

if (player released space)
   (unparent box, set box to not kinematic(
		 * 
		 * 
		 * 
		 * */
	
	}
}
