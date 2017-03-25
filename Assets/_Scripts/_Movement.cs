using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Movement : MonoBehaviour {
    private Rigidbody2D rb2d;
    public Rigidbody2D _ground;
    public int _Jump_Force = 1000;
    public int _Can_Jump = 1;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        
    }

    void Update()
    {
        bool key_down = Input.GetButtonDown("Jump" );
        Vector2 jump_force = new Vector2(10000, _Jump_Force);
        if (key_down && _Can_Jump > 0)
        {
            rb2d.AddForce(jump_force);
            _Can_Jump -= 1;
        }
        if (rb2d.position[1] < -3.2)
            _Can_Jump = 1;
        Debug.Log(rb2d.position[1]);
    }
    }
