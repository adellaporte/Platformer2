using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class NextLevel : MonoBehaviour
{


    void Update()
    {

        if ((GameObject.FindGameObjectsWithTag("flag")).Length == 0)
        {
            int i = Application.loadedLevel;
            Application.LoadLevel(i + 1);
        }

    }
}

