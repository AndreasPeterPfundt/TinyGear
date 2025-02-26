using UnityEngine;
using System.Collections;

public class MainSceneCanvas : MonoBehaviour
{
	public GameObject gGameOverText; // Game Object Game Over Text.
	public GameObject gScoreText; // Game Object Score Text.

	private GameObject gTinyGear; // Game Object Tiny Gear.

	// START.
	void Start ()
	{
		gTinyGear = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// UPDATE.
	void Update () // The game has ended.
	{
		GameOver (); // GAME OVER.
	}

	// GAME OVER.
	void GameOver () // The game has ended.
	{
		Debug.Log ("MAIN SCENE CANVAS Game Over");

		if (gTinyGear == null) // If Game Object Tiny Gear Is Equal Null.
		{
			gGameOverText.SetActive (true);
			gScoreText.SetActive (false);
		} // End If.
	}

}
