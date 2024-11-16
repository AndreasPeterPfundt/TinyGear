using UnityEngine;
using System.Collections;

public class GameControllerMain : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log ("MainSceneGameController.");

	public GameObject gOTinyGear;

	private float fTinyGearXAxisLeft;
	private float fTinyGearXAxisRight;
	private float fTinyGearYAxis;

	private int iTinyGearSpawnRandom;
	private int iTinyGearSpawnLeft;
	private int iTinyGearSpawnRight;

	private TinyGear tGTinyGear;

	private Vector2 vTinyGear;

	void Awake() // Set values.
	{
		// Debug.Log("MainSceneGameController Awake.");

		fTinyGearXAxisLeft = -1.854466f;
		fTinyGearXAxisRight = 1.854466f;
		fTinyGearYAxis = -2.5f;

		iTinyGearSpawnLeft = 1;
		iTinyGearSpawnRight = 2;
	}

	void Start() // Initialization.
	{
		// Debug.Log("MainSceneGameController Start.");

		iTinyGearSpawnRandom = Random.Range(iTinyGearSpawnLeft, iTinyGearSpawnRight);

		tGTinyGear = gOTinyGear.GetComponent<TinyGear>();

		Spawn();
	}

	void Spawn() // Make the Player apear on the either the left or right rack.
	{
		// Debug.Log("MainSceneGameController Spawn.");

		if (iTinyGearSpawnRandom == iTinyGearSpawnLeft) // If one, spawn on the left rack. If two, spawn on the right.
		{
			tGTinyGear.bIsRackLeft = true;
			tGTinyGear.bIsRackRight = false;

			vTinyGear = new Vector2(fTinyGearXAxisLeft, fTinyGearYAxis);

			Instantiate(gOTinyGear, vTinyGear, Quaternion.identity);
		}
		else if (iTinyGearSpawnRandom == iTinyGearSpawnRight)
		{
			tGTinyGear.bIsRackLeft = false;
			tGTinyGear.bIsRackRight = true;

			vTinyGear = new Vector2(fTinyGearXAxisRight, fTinyGearYAxis);

			Instantiate(gOTinyGear, vTinyGear, Quaternion.identity);
		}
	}
}
