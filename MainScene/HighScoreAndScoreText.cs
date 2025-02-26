using UnityEngine;
using System.Collections;
using UnityEngine.UI; // USER INTERFACE.

public class HighScoreAndScoreText : MonoBehaviour
{
	private GameObject gScoreText; // Game Object Score Text.

	private int iLeaderboards; // Integer Leaderboards.

	private ScoreText sScoreText; // Score Text Score Text.

	private Text tHighScoreAndScoreText; // Text Score And HighScore Text.

	// AWAKE.
	void Awake ()
	{
		gScoreText = GameObject.FindGameObjectWithTag ("ScoreText");
		sScoreText = gScoreText.GetComponent <ScoreText> ();
		tHighScoreAndScoreText = GetComponent <Text> ();
	}

	// START.
	void Start () // Display the scores.
	{
		HighScoreAndScore (); // HIGH SCORE AND SCORE.
	}

	// HIGH SCORE AND SCORE.
	public void HighScoreAndScore () // Display the scores.
	{
		Debug.Log ("SCORE AND HIGH SCORE TEXT Score And High Score");

		iLeaderboards = PlayerPrefs.GetInt ("Leaderboards");

		tHighScoreAndScoreText.text = "HIGH SCORE" // HIGH SCORE...
			+ "\n" // New Line...
			+ iLeaderboards // Integer Leaderboards...
			+ "\n" // New Line...
			+ "\n" // New Line...
			+ "SCORE" // New Line SCORE New Line...
			+ "\n" // New Line...
			+ sScoreText.iScore; // Integer Score.

		if (sScoreText.iScore < iLeaderboards) // If Integer Time Less Than Interger Leaderboards.
		{
			tHighScoreAndScoreText.text = "HIGH SCORE" // HIGH SCORE...
				+ "\n" // New Line...
				+ iLeaderboards // Integer Leaderboards...
				+ "\n" // New Line...
				+ "\n" // New Line...
				+ "SCORE" // New Line SCORE New Line...
				+ "\n" // New Line...
				+ sScoreText.iScore; // Integer Score.
		} // End If.
		else if (sScoreText.iScore > iLeaderboards) // Else If Integer Time Less Than Integer Leaderboards.
		{
			PlayerPrefs.SetInt ("Leaderboards", sScoreText.iScore);

			iLeaderboards = PlayerPrefs.GetInt ("Leaderboards");

			tHighScoreAndScoreText.text = "NEW HIGH SCORE" // NEW HIGH SCORE...
				+ "\n" // New Line...
				+ iLeaderboards // Integer Leaderboards...
				+ "\n" // New Line...
				+ "\n" // New Line...
				+ "SCORE" // New Line SCORE New Line...
				+ "\n" // New Line...
				+ sScoreText.iScore; // Integer Score.
		} // End Else If.
	}
}