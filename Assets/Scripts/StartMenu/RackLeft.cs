using UnityEngine;
using System.Collections;
using UnityEngine.UI; // User Interface.

public class RackLeft : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log ("RackLeft.");

	private AudioSource aGod;

	private CurrentScore cSScore;

	private float fTinyGearXAxis;
	private float fTinyGearYAxis;

	private GameObject gOScoreText;
	private GameObject gOTinyGear;

	private Rigidbody2D rDTinyGear;

	private string sPlayer;
	private string sScoreText;

	private TinyGear tGTinyGear;

	private Vector2 vTinyGear;

	void Awake() // Set values.
	{
		// Debug.Log ("RackLeft Awake.");

		fTinyGearXAxis = -1.854466f;
		fTinyGearYAxis = -2.5f;

		sPlayer = "Player";
		sScoreText = "ScoreText";
	}

	void Start() // Initialization.
	{
		// Debug.Log ("RackLeft Start.");

		aGod = GetComponent<AudioSource>();

		gOScoreText = GameObject.FindGameObjectWithTag(sScoreText);
		gOTinyGear = GameObject.FindGameObjectWithTag(sPlayer);

		cSScore = gOScoreText.GetComponent<CurrentScore>();

		rDTinyGear = gOTinyGear.GetComponent<Rigidbody2D>();

		tGTinyGear = gOTinyGear.GetComponent<TinyGear>();

		// TinyGearNotDestroyed();
	}

	void OnTriggerEnter2D(Collider2D cDOther) // Player is on the left or right rack.
	{
		// Debug.Log ("RackLeft OnTriggerEnter2D.");

		if (cDOther.CompareTag(sPlayer) // If the Player made the jump, set position and increase SCORE.
			&& tGTinyGear.bIsRackLeft == false
				&& tGTinyGear.bIsRackRight == true)
		{
			tGTinyGear.bIsRackLeft = true;
			tGTinyGear.bIsRackRight = false;

			vTinyGear = new Vector2(0f, 0f);

			rDTinyGear.linearVelocity = vTinyGear;

			vTinyGear = new Vector2(fTinyGearXAxis, fTinyGearYAxis);

			rDTinyGear.transform.position = vTinyGear;

			cSScore.iScore++;

			aGod.Play();
		}
	}

	void TinyGearNotDestroyed() // Checking to see if the Player has been eliminated.
	{
		// Debug.Log ("RackLeft TinyGearNotDestroyed.");

		if (gOTinyGear != null) // If the Player is not eliminated, update position and SCORE.
		{
			cSScore = gOScoreText.GetComponent<CurrentScore>();

			rDTinyGear = gOTinyGear.GetComponent<Rigidbody2D>();

			tGTinyGear = gOTinyGear.GetComponent<TinyGear>();
		}
	}
}
