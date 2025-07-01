using UnityEngine;
using System.Collections;
using UnityEngine.UI; // User Interface.

public class CurrentScore : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log("CurrentScore.");

	public int iScore;

	private string sScore;

	private Text tScore;

	void Awake() // Set values.
	{
		// Debug.Log("CurrentScore Awake.");

		sScore = "SCORE";
	}

	void Start() // Initialization.
	{
		// Debug.Log("CurrentScore Start.");

		tScore = GetComponent<Text>();
	}

	void Update() // Gameplay.
	{
		// Debug.Log("CurrentScore Update.");

		ScoreText();
	}

	void ScoreText() // Updating the score.
	{
		// Debug.Log("CurrentScore Score.");

		tScore.text = sScore
			+ "\n"
			+ iScore;
	}
}
