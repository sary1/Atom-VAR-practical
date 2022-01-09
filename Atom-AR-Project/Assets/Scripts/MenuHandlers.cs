using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandlers : MonoBehaviour
{
    public void ScanCard ()
    {
        SceneManager.LoadScene("AtomInformationScene");
    }

    public void KnowTheGameHandler()
    {
        SceneManager.LoadScene("KnowTheGameScene");
    }

    public void EnergyLevelHandler()
    {
        SceneManager.LoadScene("EnergyLevel");
    }

    public void InertGasLevelHandler()
    {
        SceneManager.LoadScene("InertGasScene");
    }
}
