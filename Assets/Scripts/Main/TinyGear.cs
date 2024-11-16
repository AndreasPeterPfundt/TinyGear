using UnityEngine;
using System.Collections;

public class TinyGear : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log ("TinyGear.");

	public bool bIsRackLeft;
	public bool bIsRackRight;

	public float fRotationSpeed;
	public float fJumpSpeedLeft;
	public float fJumpSpeedRight;

	private Rigidbody2D rDTinyGear;

	private Vector2 vTinyGear;

	void Start() // Initialization.
	{
		// Debug.Log ("TinyGear Start.");

		rDTinyGear = GetComponent<Rigidbody2D>();
	}

	void Update() // Gameplay.
	{
		// Debug.Log ("TinyGear Update.");

		#if UNITY_EDITOR // Cue this if in the editor.
		EditorControls ();
		#endif

		#if UNITY_IOS //  Cue this if in the i Operating System.
		IOperatingSystemControls ();
		#endif

		#if UNITY_STANDALONE_MACOS //  Cue this if in the Mac Operating System.
		MacOperatingSystemControls ();
		#endif

		#if UNITY_STANDALONE_WIN // Cue this if in Windows.
		WindowsControls ();
		#endif

		#if UNITY_TVOS //  Cue this if in the Operating System.
		TelevisionOperatingSystemControls ();
		#endif
	}

	void FixedUpdate() // Animations.
	{
		// Debug.Log ("TinyGear FixedUpdate.");

		TinyGearRotation();
	}

	void TinyGearRotation() // Player's rotation direction.
	{
		// Debug.Log ("TinyGear TinyGearRotation.");

		if (bIsRackLeft == true) // Rotate counter-clockwise.
		{
			rDTinyGear.MoveRotation(rDTinyGear.rotation + fRotationSpeed * Time.smoothDeltaTime);
		}

		if (bIsRackRight == true) // Rotate clockwise.
		{
			rDTinyGear.MoveRotation(rDTinyGear.rotation + -fRotationSpeed * Time.smoothDeltaTime);
		}
	}

	void EditorControls() // Controls for the editor.
	{
		// Debug.Log("TinyGear EditorControls.");

		if	(bIsRackLeft == true  // Recieving input results in the player to jump.
			&& Input.GetKeyDown(KeyCode.Space))
		{
			vTinyGear = new Vector2(fJumpSpeedRight, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRackRight == true
			&& Input.GetKeyDown(KeyCode.Space))
		{
			vTinyGear = new Vector2(fJumpSpeedLeft, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	void IOperatingSystemControls() // Controls for the i Operating System.
	{
		// Debug.Log ("TinyGear IOperatingSystemControls.");

		if	(bIsRackLeft == true // Recieving input results in the Player to jump.
			&& Input.touchCount > 0f
			&& Input.GetTouch(0).phase == TouchPhase.Began)
		{
			vTinyGear = new Vector2(fJumpSpeedRight, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRackRight == true
			&& Input.touchCount > 0f
			&& Input.GetTouch(0).phase == TouchPhase.Began)
		{
			vTinyGear = new Vector2 (fJumpSpeedLeft, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	void MacOperatingSystemControls() // Controls for the Mac Operating System.
	{
		// Debug.Log ("TinyGear MacOperatingSystemControls.");

		if	(bIsRackLeft == true // Recieving input results in the Player to jump.
			&& Input.GetKeyDown(KeyCode.Space))
		{
			vTinyGear = new Vector2(fJumpSpeedRight, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRackRight == true
			&& Input.GetKeyDown(KeyCode.Space))
		{
			vTinyGear = new Vector2(fJumpSpeedLeft, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	void TelevisionOperatingSystemControls () // Controls for the television Operating System.
	{
		// Debug.Log ("TinyGear TelevisionOperatingSystemControls.");

		if	(bIsRackLeft == true // Recieving input results in the Player to jump.
			&& Input.GetKey (KeyCode.JoystickButton14))
		{
			vTinyGear = new Vector2 (fJumpSpeedRight, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRackRight == true
			&& Input.GetKey (KeyCode.JoystickButton14))
		{
			vTinyGear = new Vector2 (fJumpSpeedLeft, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	void WindowsControls () // Controls for Windows.
	{
		// Debug.Log ("TinyGear WindowsContols.");

		if	(bIsRackLeft == true // Recieving input results in the Player to jump.
			&& Input.GetKeyDown (KeyCode.Space))
		{
			vTinyGear = new Vector2 (fJumpSpeedRight, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRackRight == true
			&& Input.GetKeyDown (KeyCode.Space))
		{
			vTinyGear = new Vector2 (fJumpSpeedLeft, 0f);

			rDTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}
}
