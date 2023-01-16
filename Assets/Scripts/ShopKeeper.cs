using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class ShopKeeper : MonoBehaviour
{
    public GameObject shopUI;

    public Transform dir1, dir2;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            shopUI.transform.DOMove(dir2.transform.position, .1f).SetEase(Ease.InOutSine);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            shopUI.transform.DOMove(dir1.transform.position, .1f).SetEase(Ease.InOutSine);
        }
    }

}
