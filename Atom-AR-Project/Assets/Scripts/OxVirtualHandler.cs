using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OxVirtualHandler : MonoBehaviour
{
    public GameObject SelectedPanel;
    VirtualButtonBehaviour vrb;
    // Start is called before the first frame update
    void Start()
    {
        SelectedPanel.SetActive(false);

        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterOnButtonPressed(onButtonPressed);
        vrb.RegisterOnButtonReleased(onButtonReleased);
    }

    private void onButtonPressed(VirtualButtonBehaviour vb)
    {
        SelectedPanel.SetActive(true);
    }

    private void onButtonReleased(VirtualButtonBehaviour vb)
    {
        SelectedPanel.SetActive(false);
    }
}
