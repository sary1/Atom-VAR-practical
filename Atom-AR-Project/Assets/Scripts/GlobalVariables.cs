using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public static int OxygenTotalElectrons = 8;
    public static int CurrentLevel = 1;
    public static int FirstLevelElectrons = 0;
    public static int SecondLevelElectrons = 0;
    public static int ThirdLevelElectrons = 0;
    public static int FourthLevelElectrons = 0;
    public static int TotalNumberOfElectrons;
    public GameObject FirstPlatform;
    public GameObject SecondPlatform;
    public GameObject ThirdPlatform;
    public GameObject FourthPlatform;
    // Start is called before the first frame update
    void Start()
    {
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
