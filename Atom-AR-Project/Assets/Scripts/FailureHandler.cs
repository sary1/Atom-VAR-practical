using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailureHandler : MonoBehaviour
{
    public void GameFailureHandler()
    {
        Debug.Log("Clicked");
        SceneManager.LoadScene("EnergyLevel");
    }
}
