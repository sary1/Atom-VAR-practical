﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPlatformElectrons : MonoBehaviour
{
    public GameObject Electron1;
    public GameObject Electron2;
    public GameObject Electron3;
    public GameObject Electron4;
    public GameObject Electron5;
    public GameObject Electron6;
    public GameObject Electron7;
    public GameObject Electron8;

    // Start is called before the first frame update
    void Start()
    {
        Electron1.SetActive(false);
        Electron2.SetActive(false);
        Electron3.SetActive(false);
        Electron4.SetActive(false);
        Electron5.SetActive(false);
        Electron6.SetActive(false);
        Electron7.SetActive(false);
        Electron8.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.ThirdLevelElectrons == 0)
        {
            Electron1.SetActive(false);
            Electron2.SetActive(false);
            Electron3.SetActive(false);
            Electron4.SetActive(false);
            Electron5.SetActive(false);
            Electron6.SetActive(false);
            Electron7.SetActive(false);
            Electron8.SetActive(false);
        }
        else if (GlobalVariables.ThirdLevelElectrons== 1)
        {
            Electron1.SetActive(true);
            Electron2.SetActive(false);
            Electron3.SetActive(false);
            Electron4.SetActive(false);
            Electron5.SetActive(false);
            Electron6.SetActive(false);
            Electron7.SetActive(false);
            Electron8.SetActive(false);
        }
        else if (GlobalVariables.ThirdLevelElectrons == 2)
        {
            Electron1.SetActive(true);
            Electron2.SetActive(true);
            Electron3.SetActive(false);
            Electron4.SetActive(false);
            Electron5.SetActive(false);
            Electron6.SetActive(false);
            Electron7.SetActive(false);
            Electron8.SetActive(false);
        }
        else if (GlobalVariables.ThirdLevelElectrons == 3)
        {
            Electron1.SetActive(true);
            Electron2.SetActive(true);
            Electron3.SetActive(true);
            Electron4.SetActive(false);
            Electron5.SetActive(false);
            Electron6.SetActive(false);
            Electron7.SetActive(false);
            Electron8.SetActive(false);
        }
        else if (GlobalVariables.ThirdLevelElectrons == 4)
        {
            Electron1.SetActive(true);
            Electron2.SetActive(true);
            Electron3.SetActive(true);
            Electron4.SetActive(true);
            Electron5.SetActive(false);
            Electron6.SetActive(false);
            Electron7.SetActive(false);
            Electron8.SetActive(false);
        }
        else if (GlobalVariables.ThirdLevelElectrons == 5)
        {
            Electron1.SetActive(true);
            Electron2.SetActive(true);
            Electron3.SetActive(true);
            Electron4.SetActive(true);
            Electron5.SetActive(true);
            Electron6.SetActive(false);
            Electron7.SetActive(false);
            Electron8.SetActive(false);
        }
        else if (GlobalVariables.ThirdLevelElectrons == 6)
        {
            Electron1.SetActive(true);
            Electron2.SetActive(true);
            Electron3.SetActive(true);
            Electron4.SetActive(true);
            Electron5.SetActive(true);
            Electron6.SetActive(true);
            Electron7.SetActive(false);
            Electron8.SetActive(false);
        }
        else if (GlobalVariables.ThirdLevelElectrons == 7)
        {
            Electron1.SetActive(true);
            Electron2.SetActive(true);
            Electron3.SetActive(true);
            Electron4.SetActive(true);
            Electron5.SetActive(true);
            Electron6.SetActive(true);
            Electron7.SetActive(true);
            Electron8.SetActive(false);
        }
        else if (GlobalVariables.ThirdLevelElectrons == 8)
        {
            Electron1.SetActive(true);
            Electron2.SetActive(true);
            Electron3.SetActive(true);
            Electron4.SetActive(true);
            Electron5.SetActive(true);
            Electron6.SetActive(true);
            Electron7.SetActive(true);
            Electron8.SetActive(true);
        }

    }
}
