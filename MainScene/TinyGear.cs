using UnityEngine;
using System.Collections;

public class TinyGear : MonoBehaviour
{
	public bool bIsLeftWall; // Boolean Is Left Wall.
	public bool bIsRightWall; // Boolean Is Right Wall.

	public float fRotationSpeed; // Float Rotation Speed.
	public float fJumpLeftSpeed; // Float Jump Left Speed.
	public float fJumpRightSpeed; // Float Jump Right Speed.

	private float fJumpYSpeed; // Float Jump Y Speed.

	private Rigidbody2D rTinyGear; // Rigidbody 2-Dimensional Tiny Gear.

	private Vector2 vTinyGear; // Vector 2 Tiny Gear.

	// AWAKE.
	void Awake ()
	{
		fJumpYSpeed = 0f;

		rTinyGear = GetComponent <Rigidbody2D> ();
	}

	// UPDATE.
	void Update () // Player taps the screen to move. Player presses the space bar to move. Player clicks to move.
	{
		#if UNITY_EDITOR // Hash Tag If editor.
		EditorControls (); // EDITOR CONTROLS.
		#endif // Hash Tag End If.

		#if UNITY_IOS // Hash Tag If I Operating System.
		IOperatingSystemControls (); // I OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.

		#if UNITY_STANDALONE_MACOS // Hash Tag If Mac Operating System.
		MacOperatingSystemControls (); // MAC OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.

		#if UNITY_TVOS // Hash Tag If Television Operating System.
		TelevisionOperatingSystemControls (); // TELEVISION OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.

		#if UNITY_STANDALONE_WIN // Hash Tag If Windows.
		WindowsControls (); // WINDOWS CONTROLS.
		#endif // Hash Tag End If.
	}

	// FIXED UPDATE.
	void FixedUpdate () // Rotating the gear the proper direction depending on the side of the screen it is on.
	{
		Animation (); // ANIMATION.
	}

	// EDITOR CONTROLS.
	void EditorControls () // Player taps the screen to move.
	{
		Debug.Log ("TINY GEAR Editor Controls");

		if	(bIsLeftWall == true // If Boolean Is Left Wall Is Equal True...
			&& Input.GetKeyDown (KeyCode.Space)) // And If Space pressed.
		{
			vTinyGear = new Vector2 (fJumpRightSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRightWall == true // Boolean Is Right Wall Is Equal true...
			&& Input. GetKeyDown(KeyCode.Space)) // And If Space pressed.
		{
			vTinyGear = new Vector2 (fJumpLeftSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	// I OPERATING SYSTEM.
	void IOperatingSystemControls () // Player taps the screen to move.
	{
		Debug.Log ("TINY GEAR I Operating System Controls");

		if	(bIsLeftWall == true // If Boolean Is Left Wall Is Equal True...
			&& Input.touchCount > 0f // And If Touch Count Greater Than Zero Float...
			&& Input.GetTouch (0).phase == TouchPhase.Began) // And If Phase Is Equal Began.
		{
			vTinyGear = new Vector2 (fJumpRightSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRightWall == true // Boolean Is Right Wall Is Equal true...
			&& Input.touchCount > 0f // And If Touch Count Greater Than Zero Float...
			&& Input.GetTouch (0).phase == TouchPhase.Began) // And If Phase Is Equal Began.
		{
			vTinyGear = new Vector2 (fJumpLeftSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	// MAC OPERATING SYSTEM CONTROLS.
	void MacOperatingSystemControls () // Player taps the screen to move.
	{
		Debug.Log ("TINY GEAR Mac Operating System Controls");

		if	(bIsLeftWall == true // If Boolean Is Left Wall Is Equal True...
			&& Input.GetKeyDown (KeyCode.Space))  // And If Space pressed.
		{
			vTinyGear = new Vector2 (fJumpRightSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRightWall == true // Boolean Is Right Wall Is Equal true...
			&& Input.GetKeyDown (KeyCode.Space))  // And If Space pressed.
		{
			vTinyGear = new Vector2 (fJumpLeftSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	// TELEVISION OPERATING SYSTEM CONTROLS.
	void TelevisionOperatingSystemControls () // Player clicks to move.
	{
		Debug.Log ("TINY GEAR Television Operating System Controls");

		if	(bIsLeftWall == true // If Boolean Is Left Wall Is Equal True...
			&& Input.GetKey (KeyCode.JoystickButton14)) // And If Joystick One Button Fourteen.
		{
			vTinyGear = new Vector2 (fJumpRightSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRightWall == true // Boolean Is Right Wall Is Equal true...
			&& Input.GetKey (KeyCode.JoystickButton14)) // And If Joystick One Button Fourteen.
		{
			vTinyGear = new Vector2 (fJumpLeftSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	// WINDOWS CONTROLS.
	void WindowsControls () // Player clicks to move.
	{
		Debug.Log ("TINY GEAR Windows Controls");

		if	(bIsLeftWall == true // If Boolean Is Left Wall Is Equal True...
			&& Input.GetKeyDown (KeyCode.Space))  // And If Space pressed.
		{
			vTinyGear = new Vector2 (fJumpRightSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRightWall == true // Boolean Is Right Wall Is Equal true...
			&& Input.GetKeyDown (KeyCode.Space))  // And If Space pressed.
		{
			vTinyGear = new Vector2 (fJumpLeftSpeed, fJumpYSpeed);

			rTinyGear.linearVelocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	// ANIMATION.
	void Animation () // Spin the gear left or right depending on the wall it is touching.
	{
		Debug.Log ("TINY GEAR Rotation");

		if (bIsLeftWall == true) // Boolean Is Left Wall Is Equal True.
		{
			rTinyGear.MoveRotation (rTinyGear.rotation + fRotationSpeed * Time.smoothDeltaTime);
		} // End If.

		if (bIsRightWall == true) // Boolean Is Right Wall Is Equal True.
		{
			rTinyGear.MoveRotation (rTinyGear.rotation + -fRotationSpeed * Time.smoothDeltaTime);
		} // End If.
	}
}
