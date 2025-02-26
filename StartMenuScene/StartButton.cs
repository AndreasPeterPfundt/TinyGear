using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
	private AudioSource aDevil; // Audio source Devil.

	private string sMainScene;

	// AWAKE.
	void Awake ()
	{
		aDevil = GetComponent <AudioSource> ();

		sMainScene = "MainScene";
	}

	// START GAME.
	public void StartGame () // Play the game.
	{
		Debug.Log ("START BUTTON Start Game");

		aDevil.Play ();
		Application.LoadLevel("MainScene");
		//SceneManager.LoadScene (sMainScene);
	}
}
