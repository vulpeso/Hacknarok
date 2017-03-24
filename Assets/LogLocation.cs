using UnityEngine;
using System.Collections;

public class LogLocation : MonoBehaviour {



	//LocationInfo li = new LocationInfo();
	/*void Start () {

		//Debug.Log ("Twoja lokacja to: " + li.latitude.ToString("0.00") +" "+ li.longitude.ToString("0.00")+"\n");
	}*/


	IEnumerator Start()
	{
		// First, check if user has location service enabled
		if (!Input.location.isEnabledByUser) {
			Debug.Log("GPS is not enabled!");
			yield break;
		}
		
		// Start service before querying location
		Input.location.Start();
		
		// Wait until service initializes
		int maxWait = 20;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
		{
			yield return new WaitForSeconds(1);
			maxWait--;
		}
		
		// Service didn't initialize in 20 seconds
		if (maxWait < 1)
		{
			print("Timed out");
			yield break;
		}
		
		// Connection has failed
		if (Input.location.status == LocationServiceStatus.Failed)
		{
			Debug.Log("Unable to determine device location");
			yield break;
		}
		else
		{
			// Access granted and location value could be retrieved
			Debug.Log("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
		}
		
		// Stop service if there is no need to query location updates continuously
		Input.location.Stop();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
