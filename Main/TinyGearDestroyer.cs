using UnityEngine;
using System.Collections;

public class TinyGearDestroyer : MonoBehaviour
{
	// Declerations are all alphabeticalized.

	// Debug.Log("TinyGearDestroyer.");

	public float fSeconds;

	private AudioSource aSDevil;

	private Color cColor;

	private float fAlpha;
	private float fBlue;
	private float fGreen;
	private float fRed;

	private SpriteRenderer sRTinyGearDestroyer;

	private string sPlayer;

	void Awake () // Set values.
	{
		fAlpha = 255f;
		fBlue = 255f;
		fGreen = 255f;
		fRed = 255f;

		sPlayer = "Player";
	}

	void Start() // Initialization.
	{
		aSDevil = GetComponent<AudioSource>();

		sRTinyGearDestroyer = GetComponent<SpriteRenderer>();
	}

	void OnTriggerEnter2D(Collider2D cDOther) // Colliding with a enemy rack results in game ending.
	{
		// Debug.Log("TinyGearDestroyer OnTriggerEnter2D.");

		if (cDOther.CompareTag(sPlayer)) // Check to see if the player collided with the enemy rack and remove them.
		{
			aSDevil.Play();
			StartCoroutine(RackDestroyerAlpha());
			Destroy(cDOther.gameObject);
			
			cDOther = null;
		}
	}

	IEnumerator RackDestroyerAlpha() // Make rack destroyer flicker when player cllides with it before completely removing.
	{
		// Debug.Log("TinyGearDestroyer RackDestroyerAlpha.");

		fAlpha = 0f;

		cColor = new Color (fRed, fGreen, fBlue, fAlpha);

		sRTinyGearDestroyer.color = cColor;

		fAlpha = 255f;

		cColor = new Color (fRed, fGreen, fBlue, fAlpha);

		yield return new WaitForSeconds(fSeconds);

		sRTinyGearDestroyer.color = cColor;

		fAlpha = 0f;

		cColor = new Color (fRed, fGreen, fBlue, fAlpha);

		yield return new WaitForSeconds(fSeconds);

		sRTinyGearDestroyer.color = cColor;
	}
}
