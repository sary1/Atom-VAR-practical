using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentLevelLetter : MonoBehaviour
{
    public GameObject K;
    public GameObject L;
    public GameObject M;
    public GameObject N;
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalVariables.CurrentLevel == 1)
        {
            K.SetActive(true);
            L.SetActive(false);
            M.SetActive(false);
            N.SetActive(false);
        } else if (GlobalVariables.CurrentLevel == 2)
        {
            K.SetActive(false);
            L.SetActive(true);
            M.SetActive(false);
            N.SetActive(false);
        }
        else if (GlobalVariables.CurrentLevel == 3)
        {
            K.SetActive(false);
            L.SetActive(false);
            M.SetActive(true);
            N.SetActive(false);
        }
        else if (GlobalVariables.CurrentLevel == 4)
        {
            K.SetActive(false);
            L.SetActive(false);
            M.SetActive(false);
            N.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.CurrentLevel == 1)
        {
            K.SetActive(true);
            L.SetActive(false);
            M.SetActive(false);
            N.SetActive(false);
        }
        else if (GlobalVariables.CurrentLevel == 2)
        {
            K.SetActive(false);
            L.SetActive(true);
            M.SetActive(false);
            N.SetActive(false);
        }
        else if (GlobalVariables.CurrentLevel == 3)
        {
            K.SetActive(false);
            L.SetActive(false);
            M.SetActive(true);
            N.SetActive(false);
        }
        else if (GlobalVariables.CurrentLevel == 4)
        {
            K.SetActive(false);
            L.SetActive(false);
            M.SetActive(false);
            N.SetActive(true);
        }
    }
}
