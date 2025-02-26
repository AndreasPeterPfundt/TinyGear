using UnityEngine;
using System.Collections;

public class TinyGearDestroyer : MonoBehaviour
{
	private AudioSource aDevil; // Audio Source Devil.

	private Color cColor;

	private float fAlpha; // Float Alpha.
	private float fBlue; // Float Blue.
	private float fGreen; // Float Green.
	private float fRed; // Float Red.
	private float fSeconds; // Float Seconds.

	private SpriteRenderer sTinyGearDestroyer; // Sprite renderer Tiny Gear Destroyer.

	// AWAKE.
	void Awake ()
	{
		aDevil = GetComponent <AudioSource> ();
		sTinyGearDestroyer = GetComponent <SpriteRenderer> ();
	}

	// ON TRIGGER ENTER TWO-DIMENSIONAL.
	void OnTriggerEnter2D (Collider2D other) // Remove the player if touched and make it flicker.
	{
		Debug.Log ("TINY GEAR DESTROYER On Trigger Enter Two-Dimensional");

		if (other.CompareTag ("Player")) // If Other Compare Tag Player.
		{
			aDevil.Play ();
			StartCoroutine (TinyGearDestroyerAlpha ()); // TINY GEAR DESTROYER ALPHA.
			Destroy (other.gameObject);
		} // End If.
	}

	// TINY GEAR DESTROYER ALPHA.
	IEnumerator TinyGearDestroyerAlpha () // Make it flicker.
	{
		Debug.Log ("TINY GEAR DESTROYER Tiny Gear Destroyer Alpha");

		fAlpha = 0f;
		fBlue = 255f;
		fGreen = 255f;
		fRed = 255f;
		fSeconds = 0.1f;

		cColor = new Color (fRed, fGreen, fBlue, fAlpha);

		sTinyGearDestroyer.color = cColor;

		fAlpha = 255f;

		cColor = new Color (fRed, fGreen, fBlue, fAlpha);

		yield return new WaitForSeconds(fSeconds);

		sTinyGearDestroyer.color = cColor;

		fAlpha = 0f;

		cColor = new Color (fRed, fGreen, fBlue, fAlpha);

		yield return new WaitForSeconds(fSeconds);

		sTinyGearDestroyer.color = cColor;
	}
}
