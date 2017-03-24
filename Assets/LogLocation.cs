using UnityEngine;
using System.Collections;

public class LogLocation : MonoBehaviour {
	LocationInfo li = new LocationInfo();
	// Use this for initialization
	void Start () {
		Debug.Log ("Twoja lokacja to: " + li.latitude.ToString("0.00") +" "+ li.longitude.ToString("0.00")+"\n");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
