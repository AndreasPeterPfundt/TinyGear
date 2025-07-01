using UnityEngine;
using System.Collections;

public class RacksDestroyer : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log("Racks Destroyer.");

	public RacksSpawner rSRacksSpawner;

	private string sRacks;

	void Awake() // Set values.
	{
		// Debug.Log("RacksDestroyer Awake.");

		sRacks = "Racks";
	}

	void OnTriggerEnter2D(Collider2D cDOther) // Check to see if this is a set of racks.
	{
		// Debug.Log("RacksDestroyer OnTriggerEnter2D.");

		if (cDOther.CompareTag(sRacks)) // If a set of racks come into contact, remove and respawn.
		{
			rSRacksSpawner.Respawn();
			Destroy(cDOther.gameObject);

			cDOther = null;
		}
	}
}
