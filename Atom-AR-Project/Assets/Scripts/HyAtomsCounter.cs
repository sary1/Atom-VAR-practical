using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HyAtomsCounter : MonoBehaviour
{
    public Text HyTextValue;
    // Start is called before the first frame update
    void Start()
    {
        HyTextValue.text = CombinationGlobalVariables.HydrogenAtoms.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        HyTextValue.text = CombinationGlobalVariables.HydrogenAtoms.ToString();
    }
}
