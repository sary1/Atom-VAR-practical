using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseElectronCount : MonoBehaviour
{
    // Start is called before the first frame update
    public void ElectronIncreaser ()
    {
        if (GlobalVariables.CurrentLevel == 1 && GlobalVariables.FirstLevelElectrons < 8)
        {
            GlobalVariables.FirstLevelElectrons++;
        } else if (GlobalVariables.CurrentLevel == 2 && GlobalVariables.SecondLevelElectrons < 8)
        {
            GlobalVariables.SecondLevelElectrons++;
        }
        else if (GlobalVariables.CurrentLevel == 3 && GlobalVariables.ThirdLevelElectrons < 8)
        {
            GlobalVariables.ThirdLevelElectrons++;
        }
        else if (GlobalVariables.CurrentLevel == 4 && GlobalVariables.FourthLevelElectrons < 8)
        {
            GlobalVariables.FourthLevelElectrons++;
        }
    }
}
