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
            Debug.Log("-----------------------------------");
            Debug.Log(GlobalVariables.FirstLevelElectrons);
            Debug.Log(GlobalVariables.SecondLevelElectrons);
            Debug.Log(GlobalVariables.ThirdLevelElectrons);
            Debug.Log(GlobalVariables.FourthLevelElectrons);
            Debug.Log("Oxygen Successful");
            Debug.Log("-----------------------------------");
            SceneManager.LoadScene("SuccessScene");
        } else
        {
            Debug.Log("-----------------------------------");
            Debug.Log(GlobalVariables.FirstLevelElectrons);
            Debug.Log(GlobalVariables.SecondLevelElectrons);
            Debug.Log(GlobalVariables.ThirdLevelElectrons);
            Debug.Log(GlobalVariables.FourthLevelElectrons);
            Debug.Log("Oxygen Failed");
            Debug.Log("-----------------------------------");
            SceneManager.LoadScene("FailureScene");
        }
    }
}
