using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Players
{
    public PlayerType playerType;
    public GameObject player_;
}

public enum PlayerType
{
    green,
    yellow,
    purple,
    blue
}

public class PlayerManager : MonoBehaviour
{
    public Transform players;
    public Players[] playersType;

    public delegate void ShirtEvent(PlayerType playerType);
    public static event ShirtEvent OnEnableShirt = delegate { };

    // Start is called before the first frame update
    void Start()
    {
        players = GetComponent<Transform>();

 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            getChild(PlayerType.yellow); 
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            getChild(PlayerType.purple);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            getChild(PlayerType.blue);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            getChild(PlayerType.green);
        }


    }



    //public void EnableShirt(PlayerType playerType)
    //{

    //}

    public void SetYellowActive()
    {
        getChild(PlayerType.yellow);
    }

    public void SetPurpleActive()
    {
        getChild(PlayerType.purple);
    }

    public void SetblueActive()
    {
        getChild(PlayerType.blue);
    }

    public void SetGreenActive()
    {
        getChild(PlayerType.green);
    }

    public void getChild(PlayerType type)
    {
        for (int i = 0; i < playersType.Length; i++)
        {

            //if (playersType[i].playerType == type)
            //{
            //    Debug.Log(playersType[i].playerType);
            //    playersType[i].player_.SetActive(true);
            //}

            bool myBoolean = playersType[i].playerType == type;
            playersType[i].player_.SetActive(myBoolean);

            //ADV.
            //playersType[i].player_.SetActive(playersType[i].playerType == type);



        }


        Debug.Log("Out of Iteration");

    }

    




}

