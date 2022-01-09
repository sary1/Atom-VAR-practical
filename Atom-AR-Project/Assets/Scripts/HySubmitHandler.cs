using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HySubmitHandler : MonoBehaviour
{
    public void HySubmissionHandler()
    {
        if (GlobalVariables.FirstLevelElectrons + GlobalVariables.SecondLevelElectrons + GlobalVariables.ThirdLevelElectrons + GlobalVariables.FourthLevelElectrons == 1 && GlobalVariables.FirstLevelElectrons == 1 && GlobalVariables.SecondLevelElectrons == 0 && GlobalVariables.ThirdLevelElectrons == 0 && GlobalVariables.FourthLevelElectrons == 0)
        {
            SceneManager.LoadScene("SuccessScene");
        }
        else
        {
            SceneManager.LoadScene("FailureScene");
        }
    }
}
