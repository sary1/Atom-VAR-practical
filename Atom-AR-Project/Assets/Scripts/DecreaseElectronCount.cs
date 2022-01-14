using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseElectronCount : MonoBehaviour
{
    public AudioSource ElectronNumberChange;
    public void ElectronDecreaser()
    {
        if (GlobalVariables.CurrentLevel == 1 && GlobalVariables.FirstLevelElectrons > 0)
        {
            GlobalVariables.FirstLevelElectrons--;
        }
        else if (GlobalVariables.CurrentLevel == 2 && GlobalVariables.SecondLevelElectrons > 0)
        {
            GlobalVariables.SecondLevelElectrons--;
        }
        else if (GlobalVariables.CurrentLevel == 3 && GlobalVariables.ThirdLevelElectrons > 0)
        {
            GlobalVariables.ThirdLevelElectrons--;
        }
        else if (GlobalVariables.CurrentLevel == 4 && GlobalVariables.FourthLevelElectrons > 0)
        {
            GlobalVariables.FourthLevelElectrons--;
        }
        ElectronNumberChange.Play();
    }
}
