using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseAtomCount : MonoBehaviour
{
    public void OxDecreaseAtomCount()
    {
        if (CombinationGlobalVariables.OxygenAtoms > 0)
        {
            CombinationGlobalVariables.OxygenAtoms--;
        }
        
    }

    public void HyDecreaseAtomCount()
    {
        if (CombinationGlobalVariables.HydrogenAtoms > 0)
        {
            CombinationGlobalVariables.HydrogenAtoms--;
        }
    }
}
