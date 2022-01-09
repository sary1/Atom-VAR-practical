using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public static int OxygenTotalElectrons;
    public static int CurrentLevel;
    public static int FirstLevelElectrons;
    public static int SecondLevelElectrons;
    public static int ThirdLevelElectrons;
    public static int FourthLevelElectrons;
    public static int TotalNumberOfElectrons;
    public GameObject FirstPlatform;
    public GameObject SecondPlatform;
    public GameObject ThirdPlatform;
    public GameObject FourthPlatform;
    // Start is called before the first frame update
    void Start()
    {
        OxygenTotalElectrons = 8;
        CurrentLevel = 1;
        FirstLevelElectrons = 0;
        SecondLevelElectrons = 0;
        ThirdLevelElectrons = 0;
        FourthLevelElectrons = 0;
        TotalNumberOfElectrons = FirstLevelElectrons + SecondLevelElectrons + ThirdLevelElectrons + FourthLevelElectrons;
    }
    
    // Update is called once per frame
    void Update()
    {
        TotalNumberOfElectrons = FirstLevelElectrons + SecondLevelElectrons + ThirdLevelElectrons + FourthLevelElectrons;

        if (CurrentLevel == 1)
        {
            FirstPlatform.SetActive(true);
            SecondPlatform.SetActive(false);
            ThirdPlatform.SetActive(false);
            FourthPlatform.SetActive(false);
        } else if (CurrentLevel == 2)
        {
            FirstPlatform.SetActive(false);
            SecondPlatform.SetActive(true);
            ThirdPlatform.SetActive(false);
            FourthPlatform.SetActive(false);
        }
        else if (CurrentLevel == 3)
        {
            FirstPlatform.SetActive(false);
            SecondPlatform.SetActive(false);
            ThirdPlatform.SetActive(true);
            FourthPlatform.SetActive(false);
        }
        else if (CurrentLevel == 4)
        {
            FirstPlatform.SetActive(false);
            SecondPlatform.SetActive(false);
            ThirdPlatform.SetActive(false);
            FourthPlatform.SetActive(true);
        }
    }
}
