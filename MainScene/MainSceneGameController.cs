using UnityEngine;
using System.Collections;

public class MainSceneGameController : MonoBehaviour
{
	public GameObject gTinyGear; // Game Object Tiny Gear.

	private float fTinyGear; // Float Tiny Gear.

	private Vector2 vTinyGear; // Vector 2 Tiny Gear.

	// AWAKE.
	void Awake () // Make the player apear on the left or right.
	{
		Spawn (); // SPAWN.
	}

	// SPAWN.
	void Spawn () // Make the player apear on the left or right.
	{
		Debug.Log ("GAME CONTROLLER Spawn");

		fTinyGear = Random.Range (0f, 2f);

		if (fTinyGear < 1f) // If Float Tiny Gear Less Than One Float.
		{
			vTinyGear = new Vector2 (1.854466f, -2.5f);
			
			gTinyGear = Instantiate (gTinyGear, vTinyGear, Quaternion.identity);
		} // End If.
		else if (fTinyGear >= 1f) // Else if Tiny Gear Greater Than Equal One Float.
		{
			vTinyGear = new Vector2 (-1.854466f, -2.5f);
			
			gTinyGear = Instantiate (gTinyGear, vTinyGear, Quaternion.identity);
		} // End Else If.
	}
}