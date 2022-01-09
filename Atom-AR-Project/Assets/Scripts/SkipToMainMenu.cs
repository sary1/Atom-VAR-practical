using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipToMainMenu : MonoBehaviour
{
    public void SkipHandler()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
