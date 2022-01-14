using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseLevel : MonoBehaviour
{
    public AudioSource LevelChange;
    public void LevelIncreaser ()
    {
        if (GlobalVariables.CurrentLevel == 4)
        {
            GlobalVariables.CurrentLevel = 1;
        }
        else
        {
            GlobalVariables.CurrentLevel++;
        }
        LevelChange.Play();
    }
}
