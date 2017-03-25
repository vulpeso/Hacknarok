using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GameControler : MonoBehaviour
{
    public float _time = 300;
    public GameObject Block1;
    public GameObject Block2;
    private List<BlockMove> _Blocks = new List<BlockMove>();
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
            _time = Random.Range(50f, 400f);
            var go = Instantiate((((int)_time)%2==0 ? Block1 : Block2), new Vector3(9.5f, -2.5f, 0.5f), Quaternion.identity);
        }

        i++;


    }
}