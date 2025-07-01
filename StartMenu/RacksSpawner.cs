using UnityEngine;
using System.Collections;

public class RacksSpawner : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log ("RacksSpawner.");

	public GameObject gORacksSetA;
	public GameObject gORacksSetB;
	public GameObject gORacksSetC;
	public GameObject gORacksSetD;
	public GameObject gORacksSetE;

	private float fRackPositionA;
	private float fRackPositionB;
	private float fRackPositionC;
	private float fRackPositionD;

	private int iRacksRandom;
	private int iRacksSetA;
	private int iRacksSetB;
	private int iRacksSetC;
	private int iRacksSetD;
	private int iRacksSetE;

	private Vector2 vRacksSetA;
	private Vector2 vRacksSetB;
	private Vector2 vRacksSetC;
	private Vector2 vRacksSetD;
	private Vector2 vRacksSetE;

	private Quaternion qRacksSetA;
	private Quaternion qRacksSetB;
	private Quaternion qRacksSetC;
	private Quaternion qRacksSetD;
	private Quaternion qRacksSetE;

	void Awake() // Set Values.
	{
		// Debug.Log ("RacksSpawner Awake.");

		fRackPositionA = 5.12f;
		fRackPositionB = 2.56f;
		fRackPositionC = -2.56f;
		fRackPositionD = -5.12f;

		iRacksSetA = 1;
		iRacksSetB = 2;
		iRacksSetC = 3;
		iRacksSetD = 4;
		iRacksSetE = 5;
	}

	void Start() // Initialization.
	{
		// Debug.Log ("RacksSpawner Start.");

		Spawn();
	}

	public void Respawn() // Once a rack set has been eliminated make a new one.
	{
		// Debug.Log ("RacksSpawner Respawn.");

		iRacksRandom = Random.Range(iRacksSetA, iRacksSetE);

		if (iRacksRandom == iRacksSetA) // Randomly spawn a new set.
		{
			vRacksSetA = new Vector2 (transform.position.x, transform.position.y);

			qRacksSetA = Quaternion.identity;

			Instantiate (gORacksSetA, vRacksSetA, qRacksSetA);
		}
		else if (iRacksRandom == iRacksSetB)
		{
			vRacksSetB = new Vector2 (transform.position.x, transform.position.y);

			qRacksSetB = Quaternion.identity;

			Instantiate (gORacksSetB, vRacksSetB, qRacksSetB);
		}
		else if (iRacksRandom == iRacksSetC)
		{
			vRacksSetC = new Vector2 (transform.position.x, transform.position.y);

			qRacksSetC = Quaternion.identity;

			Instantiate (gORacksSetC, vRacksSetC, qRacksSetC);
		}
		else if (iRacksRandom == iRacksSetD
			)
		{
			vRacksSetD = new Vector2 (transform.position.x, transform.position.y);

			qRacksSetD = Quaternion.identity;

			Instantiate (gORacksSetD, vRacksSetD, qRacksSetD);
		}
		else if (iRacksRandom == iRacksSetE)
		{
			vRacksSetE = new Vector2 (transform.position.x, transform.position.y);

			qRacksSetE = Quaternion.identity;

			Instantiate (gORacksSetE, vRacksSetE, qRacksSetE);
		}
	}

	void Spawn() // Instantiate the very first racks upon loading the level.
	{
		// Debug.Log("RacksSpawner Spawn.");

		vRacksSetA = new Vector2(0f, fRackPositionA);

		Instantiate(gORacksSetA, vRacksSetA, qRacksSetA);

		vRacksSetA = new Vector2(0f, fRackPositionB);

		Instantiate(gORacksSetA, vRacksSetA, qRacksSetA);

		vRacksSetA = new Vector2(0f, 0f);

		Instantiate(gORacksSetA, vRacksSetA, qRacksSetA);

		vRacksSetA = new Vector2(0f, fRackPositionC);

		Instantiate(gORacksSetA, vRacksSetA, qRacksSetA);

		vRacksSetA = new Vector2(0f, fRackPositionD);

		Instantiate(gORacksSetA, vRacksSetA, qRacksSetA);
	}
}
