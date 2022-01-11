using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxAtomsCounter : MonoBehaviour
{
    public Text OxTextValue;
    // Start is called before the first frame update
    void Start()
    {
        OxTextValue.text = CombinationGlobalVariables.OxygenAtoms.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        OxTextValue.text = CombinationGlobalVariables.OxygenAtoms.ToString();
    }
}
