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
            Debug.Log("-----------------------------------");
            Debug.Log(GlobalVariables.FirstLevelElectrons);
            Debug.Log(GlobalVariables.SecondLevelElectrons);
            Debug.Log(GlobalVariables.ThirdLevelElectrons);
            Debug.Log(GlobalVariables.FourthLevelElectrons);
            Debug.Log("Oxygen Successful");
            Debug.Log("-----------------------------------");
            SceneManager.LoadScene("SuccessScene");
        }
        else
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
