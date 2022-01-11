using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseAtomCount : MonoBehaviour
{
    public void OxIncreaseAtomCount ()
    {
        CombinationGlobalVariables.OxygenAtoms++;
    }

    public void HyIncreaseAtomCount()
    {
        CombinationGlobalVariables.HydrogenAtoms++;
    }
}
