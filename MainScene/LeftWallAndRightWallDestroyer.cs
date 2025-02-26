using UnityEngine;
using System.Collections;

public class LeftWallAndRightWallDestroyer : MonoBehaviour
{
	public LeftWallAndRightWallSpawner lLeftWallAndRightWallSpawner; // Left Wall And Right Wall Spawner Left Wall And Right Wall Spawner.

	// ON TRIGGER ENTER TWO-DIMENSIONAL.
	void OnTriggerEnter2D (Collider2D other) // Kill the walls. Once a wall has been eliminated make a new one.
	{
		Debug.Log ("LEFT WALL AND RIGHT WALL DESTROYER On Trigger Enter Two-Dimensional");

		if (other.CompareTag ("LeftWallAndRightWall")) // If Other Compare Tag Left Wall And Right Wall.
		{
			lLeftWallAndRightWallSpawner.Respawn (); // RESPAWN.

			Destroy (other.gameObject);
		} // End If.
	}
}