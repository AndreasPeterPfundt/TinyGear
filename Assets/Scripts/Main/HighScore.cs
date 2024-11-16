using UnityEngine;
using System.Collections;
using UnityEngine.UI; // User Interface.

public class HighScore : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log("HighScoreText.");

	public GameObject gOScoreText;

	private CurrentScore cSCurrentScore;

	private int iLeaderboards;

	private string sHighScore;
	private string sLeaderboards;
	private string sNewHighScore;
	private string sScore;
	private string sScoreText;

	private Text tHighScore;

	void Awake() // Set values.
	{
		// Debug.Log("HighScore Awake.");

		sHighScore = "HIGH SCORE";
		sLeaderboards = "Leaderboards";
		sNewHighScore = "NEW HIGH SCORE";
		sScore = "SCORE";
		sScoreText = "ScoreText";
	}

	void Start() // Initialization.
	{
		// Debug.Log("HighScore Start.");

		iLeaderboards = PlayerPrefs.GetInt(sLeaderboards);

		cSCurrentScore = gOScoreText.GetComponent<CurrentScore>();

		tHighScore = GetComponent<Text>();

		HighScoreText();
	}

	public void HighScoreText() // Display the high score.
	{
		// Debug.Log("HighScore HighScoreText.");

		tHighScore.text = sHighScore
			+ "\n"
			+ iLeaderboards
			+ "\n"
			+ "\n"
			+ sScore
			+ "\n"
			+ cSCurrentScore.iScore;

		if (cSCurrentScore.iScore < iLeaderboards) // If current score is less than the high score, do not replace it.
		{
			tHighScore.text = sHighScore
				+ "\n"
				+ iLeaderboards
				+ "\n"
				+ "\n"
				+ sScore
				+ "\n"
				+ cSCurrentScore.iScore;
		}
		else if (cSCurrentScore.iScore > iLeaderboards)
		{
			PlayerPrefs.SetInt(sLeaderboards, cSCurrentScore.iScore);

			iLeaderboards = PlayerPrefs.GetInt(sLeaderboards);

			tHighScore.text = sNewHighScore
				+ "\n"
				+ iLeaderboards
				+ "\n"
				+ "\n"
				+ sScore
				+ "\n"
				+ cSCurrentScore.iScore;
		}
	}
}
