using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAlert : MonoBehaviour
{
    public GameObject mainMenu;
    public void OpenMainMenu()
    {
        mainMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
