using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour {

    
    public float _speed = 4.8f;
    public float health = 1f;
    // Use this for initialization
    void Start () {
    }
    
    public void Kill()
    {
        health = 0f;
    }
	// Update is called once per frame
	void Update () {
       
        transform.Translate(new Vector2(-1 , 0)*Time.deltaTime * _speed);
    }
}
