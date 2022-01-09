using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OxSubmitHandler : MonoBehaviour
{
    public void OxSubmissionHandler ()
    {
        if (GlobalVariables.FirstLevelElectrons + GlobalVariables.SecondLevelElectrons + GlobalVariables.ThirdLevelElectrons + GlobalVariables.FourthLevelElectrons == 8 && GlobalVariables.FirstLevelElectrons == 2 && GlobalVariables.SecondLevelElectrons == 6 && GlobalVariables.ThirdLevelElectrons == 0 && GlobalVariables.FourthLevelElectrons == 0)
        {
            SceneManager.LoadScene("SuccessScene");
        } else
        {
            SceneManager.LoadScene("FailureScene");
        }
    }
}
