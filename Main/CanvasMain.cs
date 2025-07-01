using UnityEngine;
using System.Collections;

public class CanvasMain : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log ("MainSceneCanvas.");

	public GameObject gOGameOverText;
	public GameObject gOScoreText;

	private bool bIsGameOverShowing;
	private bool bIsScoreShowing;
	private bool bIsWaitPeriodOver;

	private GameObject gOTinyGear;

	private string sPlayer;

	void Awake() // Set values.
	{
		// Debug.Log("MainSceneCanvas Awake.");

		bIsGameOverShowing = true;
		bIsScoreShowing = false;

		sPlayer = "Player";
	}

	void Start() // Initialization.
	{
		// Debug.Log("MainSceneCanvas Start.");

		gOTinyGear = GameObject.FindGameObjectWithTag(sPlayer);
	}

	void Update() // Gameplay.
	{
		// Debug.Log("MainSceneCanvas Update.");

			GameOver();
	}

	void GameOver() // The game has ended.
	{
		// Debug.Log("MainSceneCanvas GameOver.");

		if (gOTinyGear == null) // If the Player does not exist, end the game.
		{
			gOGameOverText.SetActive(bIsGameOverShowing);
			gOScoreText.SetActive(bIsScoreShowing);
		}
	}
}
