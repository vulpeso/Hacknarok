using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Scroll : MonoBehaviour {

    public float _speed = 1f;
    public GameObject[] pisos;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 offset = new Vector2(Time.time * _speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;

    }
}  
