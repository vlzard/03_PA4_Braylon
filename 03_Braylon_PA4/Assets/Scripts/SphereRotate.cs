﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotate : MonoBehaviour
{
    public float rotationRate = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down, rotationRate * Time.deltaTime);
    }
}
