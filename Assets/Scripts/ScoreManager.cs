using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ScoreManager : MonoBehaviour
{
    public  int intCoinsCollected;
    public TextMeshProUGUI uiCoinsCollected;

    public static ScoreManager Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;
    }
    public void RefreshCoins()
    {
       
        uiCoinsCollected.SetText(intCoinsCollected.ToString());
    }


    public  void AddCoins(int coinsToAdd)
    {
        
        intCoinsCollected += coinsToAdd;
        //uiCoinsCollected.text = "" + intCoinsCollected  ;
        uiCoinsCollected.SetText(intCoinsCollected.ToString());
    }

    public void MinusCoins(int coinsToMinus)
    {
        intCoinsCollected -= coinsToMinus;
        uiCoinsCollected.SetText(intCoinsCollected.ToString());
    }

    public int GetCurrentCoins()
    {

        return intCoinsCollected;

    }


}
