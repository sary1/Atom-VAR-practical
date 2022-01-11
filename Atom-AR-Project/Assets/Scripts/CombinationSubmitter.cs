using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombinationSubmitter : MonoBehaviour
{
    public void CombinationSubmitHandler()
    {
        if (CombinationGlobalVariables.OxygenAtoms == 1 && CombinationGlobalVariables.HydrogenAtoms == 2)
        {
            SceneManager.LoadScene("SuccessScene");
        } else
        {
            SceneManager.LoadScene("FailureCombinationScene");
        }
    }
}
