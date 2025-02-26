using UnityEngine;
using System.Collections;

public class LeftWallAndRightWall : MonoBehaviour
{
	private Rigidbody2D rLeftWallAndRightWall; // Rigidbody 2-Dimensional Left Wall And Right Wall.

	private Vector2 vLeftWallAndRightWall; // Vector 2 Left Wall And Right Wall.

//	 AWAKE.
	void Awake ()
	{
		rLeftWallAndRightWall = GetComponent <Rigidbody2D> ();
	}

	// FIXED UPDATE.
	void FixedUpdate () // Walls move downwards.
	{
		Movement (); // MOVEMENT.
	}

	// MOVEMENT.
	void Movement () // Walls move downwards.
	{
		Debug.Log ("LEFT WALL AND RIGHT WALL Movement");

		vLeftWallAndRightWall = new Vector2 (0f, -1.28f);

		rLeftWallAndRightWall.linearVelocity = vLeftWallAndRightWall;
	}
}
