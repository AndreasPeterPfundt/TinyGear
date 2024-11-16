using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log ("TryAgainButton.");

	private AudioSource aSDevil;

	private string sMain;

	void Awake () // Set values.
	{
		// Debug.Log ("TryAgainButton Awake.");

		sMain = "SA_Main";
	}

	void Start () // Initialization.
	{
		// Debug.Log ("TryAgainButton Start.");

		aSDevil = GetComponent<AudioSource>();
	}

	public void TryAgain() // When selected, restart the game.
	{
		// Debug.Log ("TryAgainButton TryAgain.");

		aSDevil.Play();
		SceneManager.LoadScene(sMain);
	}
}
