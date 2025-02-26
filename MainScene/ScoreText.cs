using UnityEngine;
using System.Collections;
using UnityEngine.UI; // USER INTERFACE.

public class ScoreText: MonoBehaviour
{
	public int iScore; // Interger Score.

	private Text tScore; // Text Score.

	// AWAKE.
	void Awake ()
	{
		tScore = GetComponent <Text> ();
	}

	// UPDATE.
	void Update () // Updating the score.
	{
		Score (); // SCORE.
	}

	// SCORE.
	void Score () // Updating the score.
	{
		Debug.Log ("SCORE Text Score");

		tScore.text = "SCORE" // SCORE...
			+ "\n" // New Line...
			+ iScore; // Integer Score.
	}
}