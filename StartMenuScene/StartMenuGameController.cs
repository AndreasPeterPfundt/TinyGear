using UnityEngine;
using System.Collections;

public class StartMenuGameController : MonoBehaviour
{
	// UPDATE.
	void Update () // Let the MENU button return the player to the home screen.
	{
		#if UNITY_EDITOR // Hash Tag If Unity I Operating System.
		EditorControls (); // EDITOR CONTROLS.
		#endif // Hash Tag End If.

		#if UNITY_IOS // Hash Tag If Unity I Operating System.
		IOperatingSystemControls (); // I OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.

		#if UNITY_STANDALONE_MACOS // Hash Tag If Unity I Operating System.
		MacOperatingSystemControls (); // MAC OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.

		#if UNITY_TVOS // Hash Tag Unity Television Operating System.
		TelevisionOperatingSystemControls (); // TELEVISION OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.
	}

	// EDITOR CONTROLS.
	void EditorControls () // Display Editor controls are active.
	{
		Debug.Log ("TINY GEAR Editor Controls");
	}

	// I OPERATING SYSTEM.
	void IOperatingSystemControls () // Display I Operating System controls are active.
	{
		Debug.Log ("TINY GEAR I Operating System Controls");
	}

	// MAC OPERATING SYSTEM CONTROLS.
	void MacOperatingSystemControls () // Display Mac Operating System controls are active.
	{
		Debug.Log ("TINY GEAR Mac Operating System Controls");
	}

	// TELEVISION OPERATING SYSTEM CONTROLS.
	void TelevisionOperatingSystemControls () // Display Television Operating System controls are active.
	{
		Debug.Log ("TINY GEAR Television Operating System Controls");
	}

		// WINDOWS CONTROLS.
	void WindowsControls () // Display Windows controls are active.
	{
		Debug.Log ("TINY GEAR Windows Controls");
	}
}
