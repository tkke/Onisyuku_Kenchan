﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreateScript : MonoBehaviour
{
    public GameObject wall;
    float timer = 0;
    int interval = 3;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= interval)
        {
            transform.position = new Vector3(0, Random.Range(-2.0f, 2.0f), 6);
            Instantiate(wall, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
