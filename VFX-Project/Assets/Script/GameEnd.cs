using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        Application.Quit();
    }
}
