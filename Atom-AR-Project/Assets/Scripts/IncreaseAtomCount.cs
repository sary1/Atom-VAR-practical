using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseAtomCount : MonoBehaviour
{
    public AudioSource AtomCountChange;
    public void OxIncreaseAtomCount ()
    {
        CombinationGlobalVariables.OxygenAtoms++;
        AtomCountChange.Play();
    }

    public void HyIncreaseAtomCount()
    {
        CombinationGlobalVariables.HydrogenAtoms++;
        AtomCountChange.Play();
    }
}
