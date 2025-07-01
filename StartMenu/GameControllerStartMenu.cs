using UnityEngine;
using System.Collections;

public class GameControllerStartMenu : MonoBehaviour
{
	// Debug.Log ("StartMenuGameController.");

	void Start() // Initialization.
	{
		#if UNITY_EDITOR // Cue this if in the editor.
		EditorControls ();
		#endif

		#if UNITY_IOS
		IOperatingSystemControls (); // Cue this if in the i Operating System.
		#endif

		#if UNITY_STANDALONE_MACOS // Cue this if in the Mac Operating System.
		MacOperatingSystemControls ();
		#endif

		#if UNITY_STANDALONE_WIN // Cue this if in Windows.
		WindowsControls ();
		#endif

		#if UNITY_TVOS
		TelevisionOperatingSystemControls (); // Cue this if in the television Operating System.
		#endif
	}

	void EditorControls() // Display editor controls being active.
	{
		// Debug.Log ("StartMenuGameController EditorControls");
	}

	void IOperatingSystemControls() // Display i Operating System controls being active.
	{
		// Debug.Log ("StartMenuGameController IOperatingSystemControls");
	}

	void MacOperatingSystemControls() // Display Mac Operating System controls being active.
	{
		// Debug.Log ("StartMenuGameController MacOperatingSystemControls");
	}

	void TelevisionOperatingSystemControls() // Display television Operating System controls being active.
	{
		// Debug.Log ("StartMenuGameController TelevisionOperatingSystemControls");
	}

	void WindowsControls() // Display Windows controls being active.
	{
		// Debug.Log ("StartMenuGameController WindowsControls");
	}
}
