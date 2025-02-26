using UnityEngine;
using System.Collections;

public class LeftWallAndRightWallSpawner : MonoBehaviour
{
	public GameObject gBigLeftWallAndBigRightWallOne; // Game Object Big Left Wall And Big Right Wall One.
	public GameObject gBigLeftWallAndBigRightWallTwo; // Game Object Big Left Wall And Big Right Wall Two.
	public GameObject gBigLeftWallsAndBigRightWalls; // Game Object Big Left Walls And Big Right Walls.
	public GameObject gSmallLeftWallsAndSmallRightWallsOne; // Game Object Medium Left Walls And Medium Right Walls One.
	public GameObject gSmallLeftWallsAndSmallRightWallsTwo; // Game Object Medium Left Walls And Medium Right Walls Two.

	public LeftWallAndRightWallSpawner lLeftWallAndRightWallSpawner; // Left Wall And Right Wall Spawner Left Wall And Right Wall Spawner.

	private float fLeftWallsAndRightWalls; // Float Left Wall And Right Wall.

	private Vector2 vBigLeftWallAndBigRightWallOne; // Vector Two Big Left Wall And Big Right Wall One.
	private Vector2 vBigLeftWallAndBigRightWallTwo; // Vector Two Big Left Wall And Big Right Wall Two.
	private Vector2 vBigLeftWallsAndBigRightWalls; // Vector Two Left Walls And Right Walls.
	private Vector2 vSmallLeftWallsAndSmallRightWallsOne; // Vector Two Big Left Walls And Big Right Walls One.
	private Vector2 vSmallLeftWallsAndSmallRightWallsTwo; // Vector Two Big Left Walls And Small Right Walls Two.

	private Quaternion qBigLeftWallAndBigRightWallOne; // Quaternion Big Left Wall And Big Right Wall One.
	private Quaternion qBigLeftWallAndBigRightWallTwo; // Quaternion Big Left Wall And Big Right Wall Two.
	private Quaternion qBigLeftWallsAndBigRightWalls; // Quaternion Left Walls And Right Walls.
	private Quaternion qSmallLeftWallsAndSmallRightWallsOne; // Quaternion Big Left Walls And Big Right Walls One.
	private Quaternion qSmallLeftWallsAndSmallRightWallsTwo; // Quaternion Big Left Walls And Small Right Walls Two.

	// START.
	void Start () // The very first walls.
	{
		Spawn (); // SPAWN.
	}

	// RESPAWN.
	public void Respawn () // Once a wall has been eliminated make a new one.
	{
		Debug.Log ("LEFT WALL AND RIGHT WALL SPAWNER Respawn");

		fLeftWallsAndRightWalls = Random.Range (0, 4);

		vBigLeftWallAndBigRightWallOne = new Vector2 (transform.position.x, transform.position.y);
		vBigLeftWallAndBigRightWallTwo = new Vector2 (transform.position.x, transform.position.y);
		vBigLeftWallsAndBigRightWalls = new Vector2 (transform.position.x, transform.position.y);
		vSmallLeftWallsAndSmallRightWallsOne = new Vector2 (transform.position.x, transform.position.y);
		vSmallLeftWallsAndSmallRightWallsTwo = new Vector2 (transform.position.x, transform.position.y);

		qBigLeftWallAndBigRightWallOne = Quaternion.identity;
		qBigLeftWallAndBigRightWallTwo = Quaternion.identity;
		qBigLeftWallsAndBigRightWalls = Quaternion.identity;
		qSmallLeftWallsAndSmallRightWallsOne = Quaternion.identity;
		qSmallLeftWallsAndSmallRightWallsTwo = Quaternion.identity;

		if (fLeftWallsAndRightWalls == 0) // If Float Left And Right Wall Less Than Equal One Float.
		{
			Instantiate (gBigLeftWallAndBigRightWallOne, vBigLeftWallAndBigRightWallOne, qBigLeftWallAndBigRightWallOne);
		} // End If.
		else if (fLeftWallsAndRightWalls == 1 // Else If Float Left And Right Wall Greater Than One Float...
		         ) // And If Float Left And Right Wall Less Than Equal Two Float.
		{ 
			Instantiate (gBigLeftWallAndBigRightWallTwo, vBigLeftWallAndBigRightWallTwo, qBigLeftWallAndBigRightWallTwo);
		} // End Else If.
		else if (fLeftWallsAndRightWalls == 2 // Else If Float Left Wall And Right Wall Greater Than Two Float...
			) // And Float Left Wall And Right Wall Less Than Equal Three Float.
		{
			Instantiate (gBigLeftWallsAndBigRightWalls, vBigLeftWallsAndBigRightWalls, qBigLeftWallsAndBigRightWalls);
		} // End Else If.
		else if (fLeftWallsAndRightWalls == 3 // Else If Float Left Wall And Right Wall Greater Than Three Float...
			) // And Float Left Wall And Right Wall Less Than Equal Four Float.
		{
			Instantiate (gSmallLeftWallsAndSmallRightWallsOne, vSmallLeftWallsAndSmallRightWallsOne, qSmallLeftWallsAndSmallRightWallsOne);
		} // End Else If.
		else if (fLeftWallsAndRightWalls == 4) // Else If Float Left Wall And Right Wall Greater Than Four Float.
		{
			Instantiate (gSmallLeftWallsAndSmallRightWallsTwo, vSmallLeftWallsAndSmallRightWallsTwo, qSmallLeftWallsAndSmallRightWallsTwo);
		} // End Else If.
	}

	// SPAWN.
	void Spawn () // The very first walls.
	{
		Debug.Log ("LEFT WALL AND RIGHT WALL SPAWNER Spawn");

		vBigLeftWallsAndBigRightWalls = new Vector2 (0f, 5.12f);

		Instantiate (gBigLeftWallsAndBigRightWalls, vBigLeftWallsAndBigRightWalls, qBigLeftWallsAndBigRightWalls);

		vBigLeftWallsAndBigRightWalls = new Vector2 (0f, 2.56f);

		Instantiate (gBigLeftWallsAndBigRightWalls, vBigLeftWallsAndBigRightWalls, qBigLeftWallsAndBigRightWalls);

		vBigLeftWallsAndBigRightWalls = new Vector2 (0f, 0f);

		Instantiate (gBigLeftWallsAndBigRightWalls, vBigLeftWallsAndBigRightWalls, qBigLeftWallsAndBigRightWalls);

		vBigLeftWallsAndBigRightWalls = new Vector2 (0f, -2.56f);

		Instantiate (gBigLeftWallsAndBigRightWalls, vBigLeftWallsAndBigRightWalls, qBigLeftWallsAndBigRightWalls);

		vBigLeftWallsAndBigRightWalls = new Vector2 (0f, -5.12f);

		Instantiate (gBigLeftWallsAndBigRightWalls, vBigLeftWallsAndBigRightWalls, qBigLeftWallsAndBigRightWalls);
	}
}