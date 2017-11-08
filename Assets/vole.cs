﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vole : MonoBehaviour
{

    // Use this for initialization
    public float movementSpeed = 10;
    public float rotateSpeed = 10;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }
}
