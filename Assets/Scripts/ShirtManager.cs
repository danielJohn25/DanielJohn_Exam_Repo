using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class ShirtManager : MonoBehaviour
{

    public GameObject[] shirtBtns;

    public ShirtManager Instance;

    //[SerializeField]
    //public  int price;
    public int playerCoins;

    [SerializeField]  int money;

    public Button[] btn;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shirtBtns.Length; i++)
        {
            shirtBtns[i].SetActive(false);
        }

        //btn = GetComponent<Button>();

        //money = ScoreManager.Instance.GetCurrentCoins();
    
    }

    // Update is called once per frame
    void Update()
    {
        //money = ScoreManager.Instance.GetCurrentCoins();
        //Debug.Log(ScoreManager.Instance.GetCurrentCoins());
    }

    public void BuyShirt(string index)
    {
        for (int i = 0; i < shirtBtns.Length; i++)
        {
            for (int j = 0; j < btn.Length; j++)
            {
                if (ScoreManager.Instance.intCoinsCollected >= shirtBtns[i].GetComponent<Shirts>().shirtPrice)
                {
                    if (shirtBtns[i].name == index && ScoreManager.Instance.intCoinsCollected >= shirtBtns[i].GetComponent<Shirts>().shirtPrice)
                    {

                        //ScoreManager.Instance.intCoinsCollected -= shirtBtns[i].GetComponent<Shirts>().shirtPrice;
                        ScoreManager.Instance.MinusCoins(shirtBtns[i].GetComponent<Shirts>().shirtPrice);

                        shirtBtns[i].SetActive(true);
                        btn[i].enabled = false;
                        btn[i].GetComponentInChildren<TextMeshProUGUI>().text = "SOLD";
                        ScoreManager.Instance.RefreshCoins();

                        //Debug.Log("shirt price: " + shirtBtns[i].GetComponent<Shirts>().shirtPrice + "PRICE NOW IS  " + ScoreManager.Instance.GetCurrentCoins());
                        
                        break;
                    }

                }
            }

        }

    }

}
