using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //public

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.GetComponent<PlayerManager>())
        //    return;

        if (collision.tag == "Player")
        {
            ScoreManager.Instance.AddCoins(1);
            Destroy(gameObject);
        }
    }


}
