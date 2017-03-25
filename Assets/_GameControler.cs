using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameControler : MonoBehaviour
{
    public int _time = 300;
    public GameObject Block;
    public int i = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (i > _time)
        {
            i = 0;



            var go = Instantiate(Block, new Vector3(8.38f, -2.52f, 0.5f), Quaternion.identity);




        }
        i++;
    }
}