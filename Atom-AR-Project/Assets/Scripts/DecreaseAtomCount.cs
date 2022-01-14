using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseAtomCount : MonoBehaviour
{
    public AudioSource AtomCountChange;
    public void OxDecreaseAtomCount()
    {
        if (CombinationGlobalVariables.OxygenAtoms > 0)
        {
            CombinationGlobalVariables.OxygenAtoms--;
        }
        AtomCountChange.Play();
    }

    public void HyDecreaseAtomCount()
    {
        if (CombinationGlobalVariables.HydrogenAtoms > 0)
        {
            CombinationGlobalVariables.HydrogenAtoms--;
        }
        AtomCountChange.Play();
    }
}
