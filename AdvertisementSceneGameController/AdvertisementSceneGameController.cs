using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements; // ADVERTISEMENTS.

public class AdvertisementSceneGameController : MonoBehaviour
{
	#if UNITY_ADS
	private string placementId = "rewardedVideo";

	// AWAKE.
	void Awake () // Get variables.
	{
		Advertisement.Initialize ("1354066", false);

		StartCoroutine (LoadAdvertisement ()); // LOAD ADVERTISEMENT.
	}

	// LOAD ADVERTISEMENT.
	IEnumerator LoadAdvertisement () // Wait until ready.
	{
		Debug.Log ("ADVERTISEMENT GAME CONTROLLER LoadAdvertisement");

		while (!Advertisement.IsReady ())
		{
			yield return null;
		} // End While.

		var options = new ShowOptions
		{
			resultCallback = HandleShowResult
		};

		Advertisement.Show (placementId, options);
	}

	// HANDLE SHOW RESULT.
	private void HandleShowResult (ShowResult result) // Display the advertisement.
	{
		Debug.Log ("ADVERTISEMENT GAME CONTROLLER Handle Show Result");

		switch (result)
		{
		case ShowResult.Finished:
			Application.LoadLevel ("StartMenuScene");
			break;
		case ShowResult.Skipped:
			Application.LoadLevel ("StartMenuScene");
			break;
		case ShowResult.Failed:
			Application.LoadLevel ("StartMenuScene");
			break;
		} // End Switch.
	}
	#elif UNITY_TVOS
	void Awake ()
	{
		Application.LoadLevel ("StartMenuScene");
	}
	#endif // End Hashtag Else If.
}
