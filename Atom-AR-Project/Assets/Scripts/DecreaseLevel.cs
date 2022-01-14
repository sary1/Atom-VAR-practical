using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseLevel : MonoBehaviour
{
    public AudioSource LevelChange;
    public void LevelDecreaser()
    {
        if (GlobalVariables.CurrentLevel == 1)
        {
            GlobalVariables.CurrentLevel = 4;
        }
        else
        {
            GlobalVariables.CurrentLevel--;
        }
        LevelChange.Play();
    }
}
