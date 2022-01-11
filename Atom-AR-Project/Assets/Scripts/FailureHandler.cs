using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailureHandler : MonoBehaviour
{
    public void GameFailureHandler()
    {
        SceneManager.LoadScene("EnergyLevel");
    }

    public void GameInertFailureHandler()
    {
        SceneManager.LoadScene("InertGasScene");
    }

    public void CombinationInertFailureHandler()
    {
        SceneManager.LoadScene("CombinationScene");
    }
}
