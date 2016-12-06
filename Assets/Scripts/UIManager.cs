using UnityEngine;
using System.Collections;


public class UIManager : MonoBehaviour {


    public void StartGame()
    {

        Application.LoadLevel("Main");

    }

    public void StartLevelTwo()
    {

        Application.LoadLevel("Scene2");
    }

    public void StartLevelThree()
    {

        Application.LoadLevel("Scene3");
    }
}
