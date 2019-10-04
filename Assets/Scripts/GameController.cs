using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Menu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuController.ActiveMenu(Menu);
        }
    }
    public static void ExitAplication()
    {
        Application.Quit();
    }
}
