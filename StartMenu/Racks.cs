using UnityEngine;
using System.Collections;

public class Racks : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log ("Racks.");

	public float sRacksSpeed;

	private Rigidbody2D rDRacks;

	private Vector2 vRacks;

	void Start() // Initialization.
	{
		// Debug.Log ("Racks Start.");

		rDRacks = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() // Animation.
	{
		// Debug.Log ("Racks FixedUpdate.");

		Movement();
	}

	void Movement() // Walls move downwards.
	{
		// Debug.Log ("Racks Movement.");

		vRacks = new Vector2(0f, sRacksSpeed);

		rDRacks.linearVelocity = vRacks;
	}
}
