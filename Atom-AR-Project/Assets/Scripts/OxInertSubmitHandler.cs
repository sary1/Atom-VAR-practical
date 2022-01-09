using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OxInertSubmitHandler : MonoBehaviour
{
    public void OxSubmissionHandler()
    {
        if (GlobalVariables.FirstLevelElectrons + GlobalVariables.SecondLevelElectrons + GlobalVariables.ThirdLevelElectrons + GlobalVariables.FourthLevelElectrons == GlobalVariables.NeonTotalElectrons && GlobalVariables.FirstLevelElectrons == 2 && GlobalVariables.SecondLevelElectrons == 8 && GlobalVariables.ThirdLevelElectrons == 0 && GlobalVariables.FourthLevelElectrons == 0)
        {
            SceneManager.LoadScene("SuccessScene");
        }
        else
        {
            SceneManager.LoadScene("FailureInertScene");
        }
    }
}
