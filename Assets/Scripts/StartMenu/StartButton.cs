using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log ("StartButton.");

	private AudioSource aSDevil; // Audio source Devil.

	private string sMain;

	void Awake () // Set values.
	{
		// Debug.Log ("StartButton Awake.");

		sMain = "SA_Main";
	}

	void Start () // Initialization.
	{
		// Debug.Log ("StartButton Start.");

		aSDevil = GetComponent<AudioSource>();

		sMain = "SA_Main";
	}

	public void StartGame() // When START button is selected, start the game.
	{
		// Debug.Log ("StartButton StartGame.");

		aSDevil.Play();
		SceneManager.LoadScene(sMain);
	}
}
