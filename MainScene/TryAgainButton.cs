using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
	private AudioSource aDevil; // Audio source Devil.

	// AWAKE.
	void Awake ()
	{
		aDevil = GetComponent <AudioSource> ();
	}
		
	// TRY AGAIN.
	public void TryAgain () // Replay the game.
	{
		Debug.Log ("TRY AGAIN BUTTON Try Again");

		aDevil.Play ();
		Application.LoadLevel (Application.loadedLevelName);
	}
}