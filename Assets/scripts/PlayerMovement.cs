using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	
	public float moveSpeed = 5f;
	private bool isGrounded = true;
	Rigidbody rbody;
	Vector3 inputVector; // remembers what direction I want to go in based on input
	
	public Transform myCamera; // assign in Inspector
	
	// Use this for initialization
	void Start ()
	{
		rbody = GetComponent<Rigidbody>(); // remember shortcut to access rigidbody
		
	}
	
	// Update is called once per frame
	// don't use update when using physics
	// update is when input/graphics run
	void Update ()
	{
		/*
		if (isGrounded)
		{
			float jump = Input.GetButtonDown ("Jump") ? 0.5f : 0f;
			inputVector = new Vector3(Input.GetAxis ("Horizontal"), jump, Input.GetAxis("Vertical"));
			Debug.Log ("Input: " + inputVector);
			// good for smooth movements because numbers aren't used
		}
		*/
		
		//float mouseX = Input.GetAxis ("Mouse X"); // number from -1 to 1f
		float mouseY = -Input.GetAxis ("Mouse Y");
		
		//transform.Rotate (mouseY, mouseX, 0f); // turn left or right based on mouseX, up or down based on mouseY
		
		myCamera.Rotate (mouseY, 0f, 0f); //rotate camera up and down (separately from player)
		//myCamera.Rotate (0f, mouseX, 0f); // rotate camera left and right (separately from player)
		
	}
	
	// FixedUpdate is when physics runs, physics forces are applied
	void FixedUpdate()
	{
		// Preserve our y-velocity
		float yVelocity = rbody.velocity.y; // remembers our y-velocity
		rbody.velocity = transform.TransformDirection ( inputVector ) * moveSpeed;
		rbody.velocity += new Vector3(0f, yVelocity, 0f); // adding our y-velocity back
		
		inputVector = new Vector3(inputVector.x, 0, inputVector.z);
		//Debug.Log ("Velocity: " + rbody.velocity);
	}

	void OnCollisionStay (Collision coll)
	{
		isGrounded = true;

		float jump = Input.GetButtonDown ("Jump") ? 0.5f : 0f;
		inputVector = new Vector3(Input.GetAxis ("Horizontal"), jump, Input.GetAxis("Vertical"));
		//Debug.Log ("Input: " + inputVector);
	}
	
	void OnCollisionExit(Collision coll)
	{
		if (isGrounded)
		{
			isGrounded = false;   
		}
	}
}
