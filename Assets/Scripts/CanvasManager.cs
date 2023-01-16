using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasManager : MonoBehaviour
{
    public GameObject uiGO;

 
    public void CloseIntro()
    {
        uiGO.SetActive(false);
    }

}
