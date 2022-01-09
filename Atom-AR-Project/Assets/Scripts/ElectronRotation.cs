﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronRotation : MonoBehaviour
{
    public GameObject LevelOne;
    public GameObject LevelTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelOne.transform.Rotate(0, 0 + Time.deltaTime * 15, 0 + Time.deltaTime * 35);
        LevelTwo.transform.Rotate(0, 0 + Time.deltaTime * 35, 0 + Time.deltaTime * 15);
    }
}
