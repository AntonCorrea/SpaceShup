using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessageAlert : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject text;

    public void SetText(string msg)
    {
        text.GetComponent<TextMeshProUGUI>().text = msg;
    }
    public void OpenMainMenu()
    {
        //gameManager.mainMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
