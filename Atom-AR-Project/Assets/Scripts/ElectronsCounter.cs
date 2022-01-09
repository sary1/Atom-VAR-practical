using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectronsCounter : MonoBehaviour
{
    public Text TextValue;
    // Start is called before the first frame update
    void Start()
    {
        TextValue.text = GlobalVariables.TotalNumberOfElectrons.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        TextValue.text = GlobalVariables.TotalNumberOfElectrons.ToString();
    }
}
